using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia("139918190", "Nokia Tijolo Pro Max", "78799078", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");



Smartphone iphone = new Iphone("3131331", "Iphone pro max revolution soccer 16", "314419078", 126);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Chrome");

