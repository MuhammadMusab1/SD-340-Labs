// See https://aka.ms/new-console-template for more information
using MusicSaleConsoleApp.Models;

//Testing 

Artist artist1 = new Artist("Eisha", 3);
Customer customer1 = new Customer("Musab", 57);

Song songByEisha = new Song(artist1, "Song for Cap", 2, 1);
Video videoByEisha = new Video(artist1, "I went to the Zoo", 5, 2);

artist1.Medias.Add(songByEisha); // Song can be added because it is a child of the iMedia
artist1.Medias.Add(videoByEisha); // Video can be added because it also is a child of the iMedia

artist1.GenerateEmail();
customer1.GenerateEmail();

Console.WriteLine(artist1.Email);
Console.WriteLine(customer1.Email);

artist1.Binge();
customer1.Binge();

Console.ReadLine();




/*
PART 1

Create a new directory, Models. Within it, 
create model equivalents to your Itunes project beginning with Song (int Id, string Title).

Create an abstract class, 
User (int Id, string Name, List<Song> Collection, string email). 

Create for User the method GenerateEmail, 
which appends their ID to their Name to generate an email for them.

Create the classes Artist and Customer to implement User. 
What do you need to add to these classes to have them inherit properly from User?

Add the ArtistId, Artist, and Customers properties to Song.

Have the Artist override the GenerateEmail method to prepend 
an A to the email generated in the base class.

CLASSES: 
Artist
Song
User
UserSong --> Break class between User and Song

RELATIONSHIPS
One To Many
One [Artist] can have many [Song]s
One [Song] can have only one [Artist]

Many To Many
One [User] can have many [Song]s
One [Song] can be bought by many [User]s

PART 2
Expand our system to allow for the use of different media types.
Create the interface, iMedia, with the properties Title, Runtime(How long the song is), and the method Play. 

Modify the Collection property of User to collect iMedia objects rather than Songs.

Implement iMedia as Song and Video classes.

When a Song invokes Play() it should log 
“Playing the song [Title] on your favourite music platform for [Runtime].” 

When a Video invokes Play() it should log 
“Watching [Title] on your inadequate viewing screen for [Runtime].” 

Provide User a method, Binge, which invokes Play() on each object in their Collection. 
This requires no logic beyond looping through every iMedia object and invoking iMedia.Play();
 */