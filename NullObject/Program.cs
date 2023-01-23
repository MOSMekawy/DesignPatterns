using NullObject.Pattern;

var automobile = new MiniCooper("speedy");

var nullAutomobile = AutomobileBase.NULL;

automobile.Start();
automobile.Stop();

nullAutomobile.Start();
nullAutomobile.Stop();