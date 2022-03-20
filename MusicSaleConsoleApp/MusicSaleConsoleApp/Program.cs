// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
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
 */