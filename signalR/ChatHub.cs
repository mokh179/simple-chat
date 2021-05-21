using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace signalR
{
    [HubName("chat")]
    public class ChatHub : Hub
    {

        public void sendmessage(Message msg)
        {
            //-----Steps----
            //define connection
            // create Proxy
            //start Conn
            //define fun Call server method
            //define fun subscribe server event
            Clients.All.newMSG(msg);
            //var mes = new Message()
            //{
            //    sender=name,
            //    message1=msg,
            //    date=DateTime.Now
            //};
            msg.date = DateTime.Now;
            Model1 db = new Model1();
            db.Messages.Add(msg);
            db.SaveChanges();
            

        }


        public void joining(string groupname,string username)
        {
            Groups.Add(Context.ConnectionId, groupname);
            Clients.OthersInGroup(groupname).newmember(username, groupname);
        }

        public void setnttogroup(string groupname, string username,string mes)
        {
            Clients.Group(groupname).sendall(username, groupname, mes);
        }
    }
}