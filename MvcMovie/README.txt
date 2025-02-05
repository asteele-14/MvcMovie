2025-01-18
0848
Andrew! You deleted your app! :(
Had to start again :(
VS22 17.12.0
.NET 8 version?

Created a new project....make sure it's MVC!

0848 - ran and confirmed new application created...
0849 - now test
0850 - confirmed @ https://localhost:7196/

0905 - Pretty sure i've finished Part 1 of the tutorial
now i'll start Part 2 - Add Controller
0915 - Think i've added a new 'empty' controller and added a couple methods
now i'll test it...
0929 - typed all the code so i know what i'm doing....
tested it with my own values and even tried to break it...
Modified the Welcome method in the controller, this time w/ a new variable of 'ID'
Test!
0933
I am a genius ;)
I think i've completed PArt 2? The teacher will tell me this when we do Lab 1 :)
0935

20250122 0837 ...i am not a genius :( ...i didn't even use the right name for the project....
AAAAAAHHHHHHHHHHH.....gotta start again! :(

Jeez guy...what are you doing?
Oh well...i'll start again...oh, don't forget to copy your README.txt so you can use it to continue to the next project!
0840...
Start again :(
Create New Project -....
make sure to name it properly!
MvcMovie
.NET 8 (LTR)
Configure w/ HTTPS
oh right...and NO Authentication...
0842 ...project created!

0843...added my old README back in to the new Project :)
0843...get to work!
Add a controller... - MVC Controller - Empty
0849
Confirmed the new controller and added the GET methods to output string to the modified URL
/HelloWorld
/HelloWorld/Welcome
Modified the /HelloWorld/Welcome so the 'name' and 'numTimes' parameter can be added...
Must test!
0850
Modify Welcome message to include ID...don't delete only comment out!
0851
Confirmed ...made sure to test w/ other values to confirm 
0853
Oh no i have to do the View next!
Create a new folder in Views - 'HelloWorld' ...modify a default Empty View template
0856
Confirm and tested...
0903
Now we're starting Part 4....
Added Movies model and compiled ...no errors
0925 ...whew!
Scaffolded the EF ...and ran...confirmed new Controller - MoviesController!
And new Views > Movies > with the new View pages! :)
0926
Now Migration!!!!
0928
Beautiful : No store type was specified for the decimal property 'Price' on entity type 'Movie'. This will cause values to be silently truncated if they do not fit in the default precision and scale. Explicitly specify the SQL server column type that can accommodate all the values in 'OnModelCreating' using 'HasColumnType', specify precision and scale using 'HasPrecision', or configure a value converter using 'HasConversion'.
Update-Database complete...SQL commands CREATE DATABASE complete...
Done. :)
0928
Now run the App

0932
20250122142739_AndrewsInitialCreate

2025-01-29 0843
After recovering my application (via USB...oh so 2005 ;) start working on the application
Clean, build and test!
Ugh can't find the Output window... :\

Clean started at 8:48 AM...
1>------ Clean started: Project: MvcMovie, Configuration: Debug Any CPU ------
========== Clean: 1 succeeded, 0 failed, 0 skipped ==========
========== Clean completed at 8:48 AM and took 01.596 seconds ==========

Build started at 8:48 AM...
1>------ Build started: Project: MvcMovie, Configuration: Debug Any CPU ------
Restored C:\Users\steel\source\repos\MvcMovie\MvcMovie\MvcMovie.csproj (in 164 ms).
1>MvcMovie -> C:\Users\steel\source\repos\MvcMovie\MvcMovie\bin\Debug\net8.0\MvcMovie.dll
========== Build: 1 succeeded, 0 failed, 0 up-to-date, 0 skipped ==========
========== Build completed at 8:48 AM and took 11.383 seconds ==========

0849 - Confirmed app works but DB not populated
0852 - Completed Part 5 and confirmed DB is seeded :)

Took a break...seeing some interesting things...
0907
I think i've finished Part 6...gotta test!
Cool!
Moving on to Part 7 - Search :) now i'm Google!

0922
Created a github repo....now ready to work again. :)

2025-02-05
0729
Reviewing what has been completed...testing.
Complete MvcMovie today!
0732 Cool...Movies are populated (still hate the navigation...must change)
0736 Complete Part 7-10 and push to GitHub repo!
0826
Then we want to publish!!!! :)

Clean started at 8:27 AM...
1>------ Clean started: Project: MvcMovie, Configuration: Debug Any CPU ------
========== Clean: 1 succeeded, 0 failed, 0 skipped ==========
========== Clean completed at 8:27 Clean started at 8:27 AM...
1>------ Clean started: Project: MvcMovie, Configuration: Debug Any CPU ------
========== Clean: 1 succeeded, 0 failed, 0 skipped ==========
========== Clean completed at 8:27 AM and took 00.824 seconds ==========
 and took 00.824 seconds ==========


 Now test!
All good ...now complete the tutorial! 
0829
Sweet...now i can apprend the URL to search specific items!
0833
Sweet! Added a search field for the user :)
Now i really am Google ;D
0837
Ok...let's add the Rating field!

0838
Added the 'Rating' field to the Movie object...
and just did a build....
1>MvcMovie -> C:\Users\steel\source\repos\MvcMovie\MvcMovie\bin\Debug\net8.0\MvcMovie.dll
========== Build: 1 succeeded, 0 failed, 0 up-to-date, 0 skipped ==========
========== Build completed at 8:38 AM and took 01.673 seconds ==========

0849
I think i've done the add Rating field to the DB
20250205134720_AndrewsRating
Of course whould test....but first, lets Commit












