VAR religion = 0
VAR kind = 0
VAR count = 0
VAR investigation = 0
VAR trust = 0

Voice Gone
*[Start]
    ->Start

=== Start ===
「Calm down teenagers, both your bodies and mental states need to be prepared」Some body poked you when the high priest is speaking
*[Ignore]
    ->Ceremony1
*[Turn and see what's going on]
~kind++
    You turn arround and see your neighbor's kid
    「I've been waiting for this moment since I was five! Finally I can become someone like my dad! I'll use this power to help my family and earn a lot of money!」
    **[Smile]
        ->Ceremony1
    **[「Same! We've waited for ten years and it's finally the time!」]
        ->Ceremony1
        ~kind++
    
=== Ceremony1 ===
「Focus! After this ceremony, you gain the ability of seeing the future, but remember that everyone's power of futureseeing is different. Some of you may be able to see the future after months and even years, but some may only be able to see the future after a few days.」
*[Hope my ability is powerful]
    「Now, close your eyes and feel the energy of nature...」
    **[Follow the high priest's directions]
        ***[......]
            ****[......]
            ->FutureQuestion
    
    === FutureQuestion ===
    「Can you see the future now?」
        +[「Yes」]
        ->Ceremony3
        +[「No...」]
        ->Ceremony2
    
    === Ceremony2 ===
    「Feel the energy of nature running through your body...」
    *[Follow the high priest's directions]
        **[......]
            ***[......]
            ->FutureQuestion
    
    === Ceremony3 ===
    「What do you see?」
    *[「... I can see our village」]
        -「Are there other things you can see?」
    *[「Weapons...I've never seen things like those before...」]
        -「What? Weapons?」
    *[「And PEOPLE DYING...FIRE..LASERS...ARMIES!」]
        ->Ceremony4
    
    === Ceremony4 ===
    「Stop making up stories kid. Tell me what you really see.」
    ~count++
    +[「It's really what I saw!」]
        ->Ceremony5
    +{count>=2}[「...Alright, alright, I made those up.」]
        ~count=0
        ->Village1
    
    === Ceremony5 ===
    「Impossible.All powerful priests are seeing a peaceful future of
        the village.」
        +[「But it really is what I saw!」]
            -「It's not the right time for you to fool people.」
            ++[「Trust me!」]
                ->Ceremony4

=== Village1 ===
You walked out of the temple. You hear other children talking about their visions of the future.
「I saw that I'm going to marry a beautiful girl and make a lot of money!」
「No way!」
「Dude that's a great future!」
「I saw a future that my younger sister would become one of the priests in the temple!」
「Hey, why are you so upset? Tell us what you saw!」
*[Ignore them and walk away]
    ~kind--
    ->Home1
*[「I saw a peaceful future of our village.」]
    ~kind++
    「Wow! you can see the future of the whole village?」
    「Dude you are going to be one of the priests!」
    **[Go home]
        ->Home1
*[「I saw that something bad is going to happen to our village.」]
    ~kind++
    「Hey stop joking, don't you know that the priests already told us that it's going to be a peaceful future for our village?」
    **[Go home]
        ->Home1
        
=== Home1 ===
You go back to your home. Your parents went to the big city and left you here alone, so it’s just another lonely night that you are already used to. You lie on the bed and think to yourself: why am I seeing a different future from the priests? Am I really seeing a wrong future?
*[Yes, since I’m the only one with this vision.]
	~investigation--
	~religion++
	->Home2
*[No, I still believe that what I saw was real.]
	~investigation++
	->Home2

=== Home2 ===
Is the village really going to have a peaceful future?
*[Yes, of course.]
	~investigation--
	->Home3
*[No, because I saw a different future.]
	**[I need to figure out what’s going to happen to our village.]
		~investigation++
		->Home3
	**[But there’s no way for me to do anything with it.]
		->Home3

=== Home3 ===
You fall asleep with all of your thoughts and questions. The next day, you are waked up by the knocking sound on the door.
*[Open the door]
	You open the door and see a stranger standing in front of you. “Sorry to interrupt your cozy weekend morning. I’m a traveler from the city and I really need a place for a rest, but nobody here wants to talk to me.”
    **[「That's because no one here is able to spaek」]
        「That’s because no one here is able to speak.」You write to him with pen and paper. 「Come in please and have a rest!」
        "Hmmm that's pretty starnge."
        ***「Our people sacrificed our talking ability to the Goddess in exchange for the power to see the future.」
            "What!? That's so cool! I always knew that it's gonna be interesting outside of that stupid city! Tell me more!"
            ****[Tell him about what happened in the ceremony]
                ~trust++
                "Wow that sounds pretty intense, I wonder if there's anything I can do to help you out."
                *****[「What's your hometown like?」]
                    ->Home4
            ****[tell him about your village in general]
                "What an interesting village!"
                *****[「What's your hometown like?」]
                    ->Home4

=== Home4 ===
"It's very different from here. There are skyscrapers and holographic ads... Well I don't think you understand all that do you?"
    *[Shake your head]
        "Hey you know what, maybe you can come with me and I can show you what it's like! My father is the general so it's not gonna be hard to bring you in!"
        **[Go with him]
            ->Home5
        **[Refuse and stay in the village]
            He leaves after a few hours and you decide to stay in the village. You wait for the future to come to you no matter what that's going to be.
            ->END

=== Home5 ===
You agree to leave the village together the next day and head to the big city.
"What kind of transportation do you use here?"
*[Horses]
    You point at the horses in the yard.
    "Wow! I've never rode an actual horse before!"
    He tries to ride the horse but he doesn't know how.
    **[Teach him]
        ~trust++
        ->City1
    **[Pretend you didn't see it and let him figure it out himself]
        ->City1

=== City1 ===
He finally figures out how to ride a horse. The two of you arrive at the city and he introduces you to everything you don't know about.
    *[Follow him and wonder around in the city]
        You spend the entire day travelling in the city with him. At the end of day, he brings you to his apartment.
        "I've never thought it would be an interesting job to do as a tourguide," he says to you with joy, "You can sleep in my bedroom for tonight and I'll use the sofa as my bed."
            **「Thank you!」
                "No problem, remember who gave me a place to rest back in your village?"
                He shows you where his bedroom is and goes to the living room.
                    ***[Enter the bedroom and close the door]
                        ->City2

=== City2 ===
About thirty minutes later, you hear somebody entering the apartment.
*[Get up from the bed and see what's going on]
    "... Can't you just behave like a grown-up man? The only thing you can do is causing troubles! Don't you know how busy I am with all those army training things!?"
    "I just went for a trip father, and I don't need to tell you every move I take!"
    "It's not a trip when you just vanishes without telling anyone!"
    "You just want me to listen to you like what your soldiers do, but I'm not one of them! Just stop manipulating my life!"
    **[You hear somebody running]
        "General, the weapons you asked for are ready."
        "We'll have this conversation later kid."
        ***[You hear them leaving and then the door is shut]
            "I'm sorry if I woke you up with that." He sounds annoyed and upset.
            ****[Comfort him]
                ~trust++
                「It's fine. I think he's angry because he's tired in the work. Don't blame it on him.」
                *****{trust>=2}[The two of you talked for a few minutes]
                    ->City3
                *****{trust<2}[The two of you talked for a few minutes]
                    ->End2
            ****[Do nothing]
                 *****{trust>=2}[The two of you talked for a few minutes]
                    ->City3
                *****{trust<2}[The two of you talked for a few minutes]
                    ->End2

=== End2 ===
 You left the city without figuring out anything, but at least you made yourself a friend here.
    ->END
    
=== City3 ===
You talked for a few minutes and you both think that what his father is working on could be related to the future you saw during the ceremony.
"I want to goto the Arsenal and see what's going on."
*[Join him]
    ->Arsenal1
*[Refuse to join]
    ->End2

=== Arsenal1 ===
The two of you sneak into the Arsenal. You see soldiers getting trained and a lot of weapons that you've never seen before being prepared for use.
*[「They are definitely going to attack my village!」]
    "...Here, take this camera and take some photos so that you can warn people in your village about this."
    **{investigation<2}[Take the camera]
        You take the camera and take photos of soldiers and weapons.
        "Hurry up, go back to your village!"
        ***[Head back to the village]
            「Thank you so much my friend.」
            "Hope I can see you again."
            You give eachother a smile of understanding.
            ->Village2
    **{investigation>=2}[Take the camera]
        You take the camera ant take photos of the Arsenal. When you are checking the photos, you see a statue of the Goddess that your village believe in hidden behind a pile of weapons.
        ->Arsenal2

=== Village2 ===
You rush back to the village as soon as possible.
*{kind>=2}[Tell villagers and your friends about what you saw]
    You tell villagers and friends about what you saw in the ceremony and the Arsenal and you show them the photos you took.
    They believe in you and start to prepare for the war.
    When the war break out, you join the army of the village and fight to protect you home.
    ->END
*{kind<2}[Tell villagers and your friends about what you saw]
    You tell villagers and friends about what you saw in the ceremony and the Arsenal and you show them the photos you took, but they do not believe in you. The war finally breaks out and the village is destroyed in one night.
    ->END

=== Arsenal2 ===
When you are wondering why it's there, you see the General talk to the statue.
*[Move closer and listen carefully]
    "I have prepared an army to wipe out the village. I hope that's enough lives sacrificed to you."
    "Yes, and after that I shall grant you the power and wealth you seek." A faint woman's voice answers to him.
    **[You think to yourself]
        It seems like the Goddess needs sacrifices to gain power. The villagers are only sacrificing the ability of talking but not their lives, which she really needs to become more powerful.
        ***So the Goddess and the General are on the same side.
            That explains why priests are not seeing the real future that the Goddess doesn't want them to see.
            Even the Goddess is not trustable. Should I still try to protect the village?
            ****[Of course!]
                ->Village2
            ****[No, because there's nothing I can do.]
                After that night, you stay in the city and find a job for living. Soon the war breaks out and the village is destroyed in one single night.
                ->END















->END