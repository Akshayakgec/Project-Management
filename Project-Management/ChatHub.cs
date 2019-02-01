﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Project_Management
{
    public class ChatHub : Hub
    {
        public void SendMessage(string Message, string GroupName)
        {
            //Clients.All.SendMessage(message);
            Clients.Group(GroupName).SendMessage(Message);
        }

        //public Task JoinGroup(string id ,string GroupName)
        //{
        //    return Groups.Add( id,GroupName);
        //}
        public async Task JoinRoom(string roomName)
        {

            await Groups.Add(Context.ConnectionId, roomName);
             Clients.Group(roomName).SendMessage("Akshay" + " joined.");
        }


    }
}