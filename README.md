# MTTPP-Projekt

1. Prvo preuzeti Katalon Recorder i otvoriti ga
2. Zatim unutar aplikacije pronaći direktorij "Test Suites" i unutar njega krenuti s izradom vlastitih testova pritiskom tipke "Record"
3. Nakon snimanja vlastitog testa, snimljeni test možemo izvršiti pritiskom tipke "Play test case"
4. Završetkom svih testova, u doljnem lijevom kutu aplikacije se nalazi opcija "Export" gdje možemo exportati vlastite testove u željenom obliku(programskom jeziku). U našem slučaju je to opcija: Export- C#(WebDriver+NUnit)

#Izrada aplikacije u Visual Studiu
1. Pokrenuti Visual Studio i kreirati novi projekt: File-> New-> Templates-> NUnit Test Project
2. Nakon kreiranja aplikacije potrebno je dodati nekoliko potrebnih paketa kako bi se aplikacija i željeni testovi uspješno izvršili: Project-> Manage NuGet Packages i preuzeti pakete navedene ispod:
   -NUnit framework
   -Selenium WebDriver
   -Selenium Support
   -Nunit3 Test Adapter
   -Za izvođenje testa u Firefox-u preuzeti ovaj paket: Selenium WebDriver – Gecko Driver
3. Nakon preuzimanja paketa, provjeriti da li su svi paketi uspješno instalirani.
4. Unutar UnitTest class dodati test koji je prethodno eksportiran u formatu C#(WebDriver+NUnit) te provjeriti da li klasa sadrži potrebne metode za uspješno izvršavanje testova:
   - [SetUp]
   - [TearDown]
   - [Test]
5. Ako UnitTest class sadrži potrebne metode, dopuniti željene testove po izboru(npr. dodavanje novih metodi, izmjena postojećeg koda i sl.)
6. Kad smo završili test, potrebno je odabrati opciju Build-> Build Solution kako bi se test kasnije mogao testirati
7. Ako je build uspješno izvršen, otvoriti Test Explorer: Test-> Windows-> Test Explorer i unutar njega pokrenuti testove s opcijom "Run Tests"
Ako su testovi uspješno izvršeni, gotovi smo. U suprotnom, ispraviti greške koje nam je Test Explorer ispisao, ponovno pokrenuti "Build Solution" opciju i nakon toga "Run Tests" unutar Test Explorer-a 
