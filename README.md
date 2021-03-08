# Fresh Match Hackatown

<img src="https://cdn.discordapp.com/attachments/732405970692735066/808023181415415818/ezgif-6-d7378158e08b.gif"
     style="float: left; margin-right: 10px;" />
 
## Background

Local food production is critical to green economics and global sustainability in the 21st century. Buying local can help create jobs for families
and farmers, and enrich the communities in which they are located. Local products can help reduce our carbon footprint, reduce transportation costs
and reduce the use of harmful pesticides and fertilizers. 

Despite growing demand, sourcing local food presents many challenges for restaurants, organizations, and end consumers. The farmers market often 
serves a critical role in local supply chains, where relationships are made and discovery of new products can take place. Brokers, local organizations,
and word-of-mouth relationships are also important for consumers when sourcing local products. Unfortunately, these resources are often inconvienent
or even difficult to locate, if they exist at all. Bref, : local knowledge usually preceeds local food. This creates ineffeciences in local food 
markets, as connecting buyers and sellers of local produce takes time (and sometimes money). Furthermore, it discourages restaurants and organizations
from using local food in the first place. Lastly, small farmers are cut off from many opportunities to grow their brand, as they only interact with
a limited customer base. 

## What It Does


We introduce "FreshMatch", an application designed to help businesses and private shoppers connect with local producers. Our application enhances efficiency in local food markets by reducing the time necessary for consumers to source local produce, effectively serving as a "smart broker". "FreshMatch" provides both Business to Business and Business to Customer services, which are designed to meet the needs of  all stakeholders involved in the local food indsutry. For producers, our application offers enhanced branding opportunities through an AR  scanner for use in supermarkets, which presents branded information to end consumers. For restauraunts and similar organizations, the application matches the user with local producers based on preferences indicated during account creation, using a mechanism similar to the app  "Tinder". This also benefits producers who are seeking buyers for their goods. Finally, private shoppers benefit from using the app to quickly 
locate local food during their regular shopping trip. 

## How We Built It

<img src="https://cdn.discordapp.com/attachments/732405970692735066/807989157875417138/unknown.png"
     alt="Markdown Monster icon"
     style="float: left; margin-right: 10px;" />

**Design**

We started our application development process with sotryboarding and "UX design". We used Adobe XD and Photoshop for the prototype and design of our application. We started by creating a color palette and designing several options for the background, buttons, and text fonts to use throughout the rest of the app. Once we had our basic design needs, we started to develop the UX of each page. As we have to collect a lot of information, we have chosen to separate the questions into several pages so as not to overwhelm the user.

**Development**

_Unity_

We used Unity with C # to implement the functionality of the app. We didn't use multiple Unity Scenes, instead we used layouts to turn new pages on and off in the app for better performance.

_Google Cloud_

We used Firebase for several parts of our project. We started by using FireBase authentication to authenticate user accounts and only allow one account per email address. We have also used FireBase Firestore to store the data of our buyers and sellers. We start by calling an instance of firebase and updating the database in real time as users make decisions. When users choose a specific option on the page, the database automatically updates to reflect their choices and then associates them with specific users.

_AR With Vuforia_

For the AR part of our app, we used Vuforia to deploy a marker-based AR system. We have developed small markers, the size of fruit stickers, which display information about the grower when scanned. First, we uploaded the markers we created into the Vuforias database and imported them into our unit scene. We then developed info sheets that we configured to display when viewed by the AR camera. In practical scenarios like daily shopping, the user simply opens the app and scans the marker, and it automatically displays the data sheet.

_Swipe_

The swipe mechanism (Like Tinder) was developed in Unity and provides images in the app via a link to images stored on the web.

## Challenges We Faced

Our main challenge in developing this project is definitely the size of the project itself. It is a very big project with a lot of functionalities and a lot of different sides. 
This project was also made using skills that are  "Outside of our confort zone". None of us has that much experience developing complicated mobile apps and before this point we were never able to succesfully integrate firestore in any of our projects. It was very challenging to get FireBase FireStore to work and update our data in realtime. 
It was just overall very challening to get everything ready in time. At some point, we had 40 minutes to design stickers, print them, push the succesfull app to the phone and run to the store right before it closes to get a shot of our app working.
One of the other challenges is making an 8 minute demo video in French. The three of us are more confortable speaking english but we decided to join the spirit of this hackathon and make our demo in French.

## What We're Proud Of

WE ACTUALLY FINISHED THE APP. While there is ofcourse always room for improvment, we are really proud that we were actually able to deliver a fully ducntioning app with all the features that we implemented. We are extremely proud that we were able to finally get FireBase FireStore to work in our project and store data in real time. We also tried to switch up roles in this project and do the role that is most challenging for us. for example, austin who never used firebase before implemneted the whole authentication feature by himself to be able to learn as much as possible. Ines who is not usually a designer, created some of the logoes used in the app.
Also we are very proud that we were able to join our first french hackathon and create a demo video in french!

## What We Learned

We learned a lot! We learned how to use firebase firestore in our projects and fully implement it to store data. We learned a lot about UX/UI design and how to make a beautiful app. We also learned how to work on a team with diverse skillsets and diverse backgrounds. We were in no way all developers, we had very different skills sets and we were able to combine them to create this project and learn from eachother along the way.

## What Is Next

We want to expand our database! We want to have way more users than our current sample users. 
We walso want to offer more customization where users can input their own products without having to choose from a list. We can also add profile customization for each user to make their profile look however they wanted to.
We want to also include a notifcations systmes where the users get notifcations on their phone once they're matched with somebody. 
It would also be great to use location features so that the app only mtaches buyers and sellers that are a certain distance away from eachother.
