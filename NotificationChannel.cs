using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NewFolder1
{
    public abstract class NotificationChannel
    {
        protected string ChannelName; //Поле
        public int DeliveredCount { get; set; } // Свойства
        public abstract bool IsOnline { get; }
        
        public NotificationChannel(string name) // Конструктор
        {
            this.ChannelName = name;
        }

        public abstract bool Deliver(string recipient, string message);
        public virtual string FormatPayload(string rawMessage)
        {
            return $"[ChannelName] {rawMessage}";
        }
        public void PrintAudit()
        {
            Deliver();
            FormatPayload(this.ChannelName);
        }
    }
}
