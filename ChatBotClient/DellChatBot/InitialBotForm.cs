using Microsoft.Lync.Model;
using Microsoft.Lync.Model.Conversation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using Microsoft.Lync.Model.Conversation.AudioVideo;

namespace DellChatBot
{
    public partial class InitialBotForm : Form
    {

        private LyncClient _lyncClient;
        private ConversationManager _conversationManager;
        string response = string.Empty;

        public InitialBotForm()
        {
            InitializeComponent();
            _lyncClient = LyncClient.GetClient();
            _conversationManager = _lyncClient.ConversationManager;
            _conversationManager.ConversationAdded += ConversationAdded;

        }


        private void ConversationAdded(object sender, ConversationManagerEventArgs e)
        {
            e.Conversation.Modalities[ModalityTypes.InstantMessage].Accept();
            var conversation = e.Conversation;
            conversation.ParticipantAdded += ParticipantAdded;
        }

        private void ParticipantAdded(object sender, ParticipantCollectionChangedEventArgs e)
        {
            var participant = e.Participant;
            if (participant.IsSelf)
            {
                return;
            }

            var instantMessageModality =
                e.Participant.Modalities[ModalityTypes.InstantMessage] as InstantMessageModality;
            instantMessageModality.InstantMessageReceived += InstantMessageReceived;
        }

        private void InstantMessageReceived(object sender, MessageSentEventArgs e)
        {
            TextAnalyser textAnalyser = new TextAnalyser();
            var text = e.Text.Replace(Environment.NewLine, string.Empty);

            //chatLbl1.Text = text.ToString();
            StartConversation("arundhati_mahapatro@dell.com", text);
            string myRemoteParticipantUri = (sender as InstantMessageModality).Endpoint.Uri.Replace("sip:", string.Empty);
            LogMessage(myRemoteParticipantUri, text);
            try
            {
                string strResult = "";
                if (text.ToLower().Equals("hi") || text.ToLower().Equals("hello"))
                {
                    strResult = "Hi";
                }
                else
                {
                    strResult = "You are talking about " +textAnalyser.RemoveStopwords(text);

                }
            (sender as InstantMessageModality).BeginSendMessage(strResult + "\n https://dell.service-now.com/esp/ :)", null, null);
            }
            catch (Exception ex)
            {
                LogMessage(myRemoteParticipantUri, ex.Message);
            }
        }


        void StartConversation(string myRemoteParticipantUri, string MSG)
        {

            foreach (var con in _conversationManager.Conversations)
            {
                if (con.Participants.Where(p => p.Contact.Uri == "sip:" + myRemoteParticipantUri).Count() > 0)
                {
                    if (con.Participants.Count == 2)
                    {
                        con.End();
                        break;
                    }
                }

            }

            Conversation _Conversation = _conversationManager.AddConversation();
            _Conversation.AddParticipant(_lyncClient.ContactManager.GetContactByUri(myRemoteParticipantUri));
            

            Dictionary<InstantMessageContentType, String> messages = new Dictionary<InstantMessageContentType, String>();

            messages.Add(InstantMessageContentType.PlainText, MSG);
            InstantMessageModality m = (InstantMessageModality)_Conversation.Modalities[ModalityTypes.InstantMessage];
            m.BeginSendMessage(messages, null, messages);
            LogMessage(myRemoteParticipantUri, MSG);
        }

        private static void LogMessage(string myRemoteParticipantUri, string MSG)
        {

        }
    }
}
