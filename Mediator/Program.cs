using Mediator.Pattern;

var mostafa = new AccountManager("mostafa");
var peter = new Lawyer("peter");
var samy = new Lawyer("samy");
var kero = new AccountManager("kero");

var chatRoom = new TeamChatRoom();
chatRoom.Register(mostafa);
chatRoom.Register(peter);
chatRoom.Register(samy);
chatRoom.Register(kero);

mostafa.Send("Hey fellas !!!");
samy.Send("Hey");