//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;
using RosMessageTypes.Std;

namespace RosMessageTypes.MoveBase
{
    [Serializable]
    public class MoveBaseActionFeedbackMsg : Message
    {
        public const string k_RosMessageName = "move_base_msgs/MoveBaseActionFeedback";
        public override string RosMessageName => k_RosMessageName;

        //  ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
        public HeaderMsg header;
        public Actionlib.GoalStatusMsg status;
        public MoveBaseFeedbackMsg feedback;

        public MoveBaseActionFeedbackMsg()
        {
            this.header = new HeaderMsg();
            this.status = new Actionlib.GoalStatusMsg();
            this.feedback = new MoveBaseFeedbackMsg();
        }

        public MoveBaseActionFeedbackMsg(HeaderMsg header, Actionlib.GoalStatusMsg status, MoveBaseFeedbackMsg feedback)
        {
            this.header = header;
            this.status = status;
            this.feedback = feedback;
        }

        public static MoveBaseActionFeedbackMsg Deserialize(MessageDeserializer deserializer) => new MoveBaseActionFeedbackMsg(deserializer);

        private MoveBaseActionFeedbackMsg(MessageDeserializer deserializer)
        {
            this.header = HeaderMsg.Deserialize(deserializer);
            this.status = Actionlib.GoalStatusMsg.Deserialize(deserializer);
            this.feedback = MoveBaseFeedbackMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.header);
            serializer.Write(this.status);
            serializer.Write(this.feedback);
        }

        public override string ToString()
        {
            return "MoveBaseActionFeedbackMsg: " +
            "\nheader: " + header.ToString() +
            "\nstatus: " + status.ToString() +
            "\nfeedback: " + feedback.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}
