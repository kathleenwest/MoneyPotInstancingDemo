# MoneyPotInstancingDemo
 
 The Money Pot Problem – A Demo of Concurrency in Singleton and PerCall Service Behaviors in a WCF Service Application & Client "Tester" Windows Form Application
 
 
 Project URL: 
 https://portfolio.katiegirl.net/2019/10/14/the-money-pot-problem-a-demo-of-concurrency-in-singleton-and-percall-service-behaviors-in-a-wcf-service-application-client-tester-windows-form-application/
 
 
----------------------- 

Problem Formulation


Pretend there is a fictional money pot existing unguarded on a computer server. The leprechauns have left their pot of gold unguarded and anyone can take $ money from the pot. But there is a catch: the clever elves have limited the amount of cash that can be taken per transaction request and guarded the resources to prevent multiple money grabs at the same time (resource thread locking). In a race to get all the money available from the money pot, several computer fairies are hacking into the money pot and competing against each other to get the most money. Each fairy starts their computer “client” to connect to the leprechauns’ money pot server to drain as much as they can. To their disappointment, the computer fairies find that the more client connections (competition from other hackers) and requests they make to the money pot, the less $ money they receive compared to what they would receive if only one fairy hacker was hacking the money pot. 


-------------------------

About


This project presents a simple, but fun “Money Pot” Service and Client Application demonstration. The “Money Pot” is a self-hosted (service host) WCF application with a GUI user interface to quickly demo and test the service with a client (both simple Windows Form Applications).
 
 
The service interface is defined not in the service application but in a Shared Library. This library defines the interface contracts for the $ money withdrawals and is referenced by both the client and service host projects.  


A client “tester” windows form application tests the service and provides output to the user in a simple GUI.  
In addition, a short discussion of concurrency to protect resources against multiple threads is shown along with charts, pictures, and test data to show that with multiple threads (clients) wanting the “money pot” resource, can diminish what resources an individual client thread can receive if they compete against one another.  

-------------------------

Architecture


The demo project consists of these component topics:

•	WCF Service (Self-Hosted) Application Project “MoneyServerHost”

o	MoneyPotService (Code that Implements the Service Interface)
o	App.config (Configuration for Service Host)
o	Reference to the Shared Class Library
o	Main GUI (Windows Form Application)
o	Form Code – Processes GUI User Interface


•	Shared Class Library Project “SharedLib”

o	IMoneyPotService (Interface for Service)


•	Client “Tester to Service” Windows Form Application Project “Client”

o	Reference to the Shared Class Library
o	Main Form GUI User Interface
o	Form Code – Processes GUI User Interface




