using System;
using System.Windows.Forms;

namespace Betelgeuse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Movie
        String Data = "\"Beetlejuice\" the motion picture\n\n\n"
            + "Directed by:        Tim Burton\n\n"
            + "Music by:           Danny Elfman\n\n"
            + "Distributed by:   Warner Bros.\n\n"
            + "Release Dates:  March 30th 1988\n\n"
            + "Running Time:  92 min.\n\n"
            + "Budget:              $15,000,000\n\n"
            + "Box Office:         $73,707,461\n\n\n"
            + "\"The Name in Laughter from the Hereafter\"";
        // Beetlejuice character...
        String BJBio =
            "(by: \'danessf\', IMDB)\n\n"
            + "Although only a supporting actor in his own movie, he stole every single scene he was in. So much in fact, that when he got his own animated spin-off, he was the star hands-down.\n\n"
            + "A rowdy, hyper-active and heavily decomposed live-wire, who thinks of himself as the guy who left behind a beautiful corpse, Betelgeuse is nothing short of a one-man show.\n\n"
            + "With his raspy, southern-fried voice, deadly sense-of-humor, hunger for insects and his libido (which alone is more alive than most people's entire body), this ghoul is one to watch--and one to avoid.\n\n"
            + "Beetlejuice resided, like many corpses in a grave at a cemetery. While he may have superpowers like a witch or like a genie, encased in a prison, his powers are very reduced. Released, you'll laugh... but you won't want him in your house.";
        String BJQuo = "\"It's showtime!\"\n\n";
        String BJBioQuo = "\"Ah. Well... I attended Juilliard... I'm a graduate of the Harvard business school. I travel quite extensively. I lived through the Black Plague and had a pretty good time during that. I've seen the EXORCIST ABOUT A HUNDRED AND SIXTY-SEVEN TIMES, AND IT KEEPS GETTING FUNNIER EVERY SINGLE TIME I SEE IT... NOT TO MENTION THE FACT THAT YOU'RE TALKING TO A DEAD GUY... NOW WHAT DO YOU THINK? You think I'm qualified?\"\n\n"
            + "\"Because if I tell you, you'll tell your friends, your friends are callin' me on the horn all the time, I gotta show up at shopping centers for openings and sign autographs and shit like that and it makes my life a *hell*. Okay? A living hell.\"\n\n"
            + "\"Go ahead, make my millennium.\"\n\n"
            + "\"I'm a ghost with the most, babe.\"\n\n"
            + "\"Nice f***in' model!\"\n\n"
            + "\"Attention K-Mart shoppers.\"";
        // Lydia character...
        String LDBio =
            "(by: \'dani151\', IMDB)\n\n"
            + "At first a seemingly dark character, Lydia does not ignore the weird and the strange because she is strange.\n\n"
            + "She befriends the Maitelands, the deceased primary characters, her only friends until the end of the film. Used and misunderstood by her family she wants to join them!\n\n"
            + "But all is fine in the end! Forced into a marriage to save the ones she loves, Lydia proves to be good hearted! Black and red and a hint of white her costume rarely changes.\n\n"
            + "All Lydia needs is to be loved and understood.";
        String LDQuo = "\"I am alone.\"\n\n";
        String LDBioQuo = "\"Maybe *you* can relax in a haunted house, but I can't.\"\n\n"
            + "\"My whole life is a dark room. One big dark room.\"\n\n"
            + "\"Well, I've read through that handbook for the recently deceased. It says: 'live people ignore the strange and unusual'. I, myself, am strange and unusual.\"\n\n"
            + "\"I'm not scared of sheets. Are you gross under there? Are you Night of the Living Dead under there? Like all bloody veins and pus?\"\n\n"
            + "\"They wanted me to dissect a frog, I told them it was against my religion.\"\n\n"
            + "\"Wait... what am I worried about, Otho, you can't even change a tire.\"\n\n";
        // Adam character...
        String AMBio =
            "(by: \'superflyjd\', IMDB)\n\n"
            + "Adam had a happy life as a city planner and devoted husband of Barbara. Yet after a freak accident, they drown.\n\n"
            + "Upon returning as ghosts they find that people have already moved into their once dream home. Adam then decides that him and Barbara must scare the new people out. Although they may be so desperate that they relese a dangerous Bio-Exercist.\n\n"
            + "Adam is sort of a goofball but is serious at the important times. He along with his wife befriend Lydia.";
        String AMQuo = "\"Barb, honey... we're dead. I don't think we have very much to worry about anymore.\"\n\n";
        String AMBioQuo = "\"We're not completely helpless, Barbara. I've been reading that book and there's a word for people in our situation: ghosts.\"\n\n"
            + "\"You can see us without the sheets?\"\n\n"
            + "\"Maybe this is heaven.\"\n\n"
            + "\"BEH... \" [His mouth falls out.]\n\n"
            + "\"'Handbook of the Recently Diseased'.\n"
            + "(...)\n"
            + "'Handbook for the Recently Deceased Press'.\"\n\n"
            + "\"I don't see anything about heaven OR hell. This book reads like stereo instructions. Listen to this: \"Geographical and temporal perimeters.Functional perimeters vary from manifestation to manifestation. [Snaps book shut.] Oh, this is gonna take some time, honey.\"\n\n"
            + "\"Let's watch them scatter.\"(...)\n"
            + "\"Any minute now they're gonna' come running out of that door screaming.\"(...)\n"
            + "\"Any minute now.\"(...)";
        // Barbara character...
        String BMBio =
            "(by: \'superflyjd\', IMDB)\n\n"
            + "Barbara was a happy woman married to the man of her dreams, Adam. While she cleans the house, her and her husband decide to run into town.\n\n"
            + "Just as Barbara crosses the bridge, she swerves out of the way to miss a dog (...). Her and Adam crash into the river and die.\n\n"
            + "After an unspecified amount of time, Adam and Barbara return home to find that they are ghosts (...) Soon after they die their realtor, Jan, sells their house to the, Deetzes; a rich, artsy, yuppie family that are polar opposites of the Maitland's. Although Adam and Barbara like the daughter, Lydia Deetz, they want the other family out of their house (...).\n\n"
            + "\"Barbara is shown to be strong and couragous (...) loves Lydia but initially dislikes Delia (the mother) for critizising her home decour. Barbara also constanly has to fend off from the perverted Beetlejuice.\"\n\n";

        String BMQuo = "\"You know what? I don't think we survived the crash!\"\n\n";
        String BMBioQuo = "\"[Reading the Handbook of the Recently Deceased]\nIn the book: \'Rule Number Two: the living usually won't see the dead\'. (...)\nIt just says 'won't'. God, this book is so stupid. I can't understand anything in it.\"\n[Adam takes the book and closes it.]\n\n"
            + "\"We're very unhappy.\"\n\n"
            + "\"[Furiously.] I'm gonna get her.\"\n\n"
            + "\"Well, I can't clean anything properly. The vacuum's out in the garage and we can't leave the house. Why don't they tell us something? I mean, where are all the other dead people in the world? Why is it just you and me? (...) In heaven there wouldn't be dust on everything.\"\n\n"
            + "\"You know, if I had seen a ghost at your age I would have been scared out of my wits.\"\n\n"
            + "\"[In Betelgeuse's voice.]\nLearn to throw your voice! Fool your friends! Fun at parties!\"\n\n";
        // Charles character...
        String CDBio =
            "(by: Various, Beetlejuice Wikia)\n\n"
            + "Athough he claims he just wants to relax and clip coupons (which he obviously does) he just couldn't resist his old habit of continuing his real estate career... the one he had before his \"nervous breakdown\", and intends to sell the entire town of Winter River.\n\n"
            + "Though he acts a bit too busy for his own family, he truly cares about them, as he loves his wife Delia unconditionally (even though he hates how she \"trashes the place\" with her redecorating obsession) and is more attentive to Lydia then she is, (he asks the child her opinion of the house they moved into, promises her a darkroom for her photography hobby, and even calls Lydia \"pumpkin\") despite the fact he seems to prefer the girls to spend more time with each other than with him. \n\n";
        String CDQuo = "\"What are you gonna do, Otho, viciously rearrange their enviroment?\"\n\n";
        String CDBioQuo = "\"Nice building... bad roof... goooood parking.\"\n\n"
            + "\"It's okay, there's no damage. See? It's okay. A good sturdy comfy craftsmanship. And look at that kitchen. You're finally gonna be able to cook a decent meal.\"\n\n"
            + "\"Pumpkin, sweetheart...\"\n\n"
            + "\"[After a long pause.] Yeah, well you know, maybe the house could use a little remodeling. Uh... But, why don't you just leave this room alone, okay?\"\n\n"
            + "\"Drive carefully!\"\n\n"
            + "\"Skeleton keys never work. Anyway, this can wait. We'll get a crowbar later. Where's your mother?\"\n\n"
            + "\"This thing reads like stereo instructions.\"";
        // Delia character...
        String DDBio =
            "(by: Various, Beetlejuice Wikia)\n\n"
            + "Delia is portrayed as an overdramatic artist as well as a perfectionist. She is constantly criticizing her husband Charles and criticizes her step-daughter Lydia for being a Goth and for constantly complaining.\n\n"
            + "Delia is very self-centered and puts her own interests before her husband and step-daughter. She's also known to be extremely clueless and has no respect for the dead. As proven with the former assuming that the Maitlands hanged themselves and the latter when she laughed at a remark about suicidal people spending the afterlife as civil servants.\n\n"
            + "She seemed blaze to the idea to turn her house into a place to be scared, until Otho causes the Maitlands to appear, with Barbara wearing her wedding dress and Adam in Charles' tuxedo, she began to have second thoughts.";
        String DDQuo = "[Evaluating her new home.]\n\"A little gasoline... blowtorch... no problem.\"\n\n";
        String DDBioQuo = "\"They're in there? They must live like animals. (...) [Bangs on the door.] Open this door, you dead people, or we'll bust it down and we'll drag you out by the ropes you hang yourselves with!\"\n\n"
            + "\"Lydia, I have a chance to teach you something here: you have got to take the upper hand in all situations or people, whether they're dead or alive, will walk all over you.\"\n\n"
            + "\"I'm here with you. I will live with you in this hellhole, but I must express myself. If you don't let me gut out this house and make it my own, I will go insane, and I will take you with me!\"\n\n"
            + "\"[About the house.] I noticed that too; it's like a giant... ant farm.\"\n\n"
            + "\"Please, they're dead. It's a little late to be neurotic.\"\n\n"
            + "\"This is my art, and it is dangerous! Do you think I want to die like this? \"\n\n"
            + "\"Oh look, an indoor outhouse.\"";
        // Juno character...
        String JBio =
            "(by: Various, Beetlejuice Wikia)\n\n"
            + "Wise, but quick tempered, Juno is an afterlife caseworker whom the Maitlands go to for help in dealing with the afterlife and for assistance removing the Deetz's from their home. She had Betelgeuse as an assistant at one time until he decided to go \"out on his own\" as a \"Freelance Bio-Exorcist\" who claimed he could \"get rid of the living\".\n\n"
            + "She warns the Maitlands not to summon Beetlejuice but to scare the Deetzs out of their house themselves because Betelgeuse \"does not work well with others\". She now uses the Receptionist as a new assistant.\n\n"
            + "She died by committing suicide before she went to the Netherworld, and since she is a civil servant, we know then that she slit her own throat.";
        String JQuo = "\"[Knowingly.] I heard. Tore your faces right off. It obviously doesn't do any good to pull your heads off in front of people if they can't see you.\"\n\n";
        String JBioQuo = "\"What did you expect? You're dead.\"\n\n"
            + "\"Start simply, do what you know, use your talents, practice. You should've been studying those lessons since day one.\"\n\n"
            + "\"[Rolls her eyes.] Never trust the living! We cannot have a routine haunting like yours provide proof that there is existence beyond death.\"\n\n"
            + "\"I'm not your coach! *He* survived. (...) Will you get out of here! Go on, get downstairs! 'Men's room'! Are you kidding? Can't you read signs?\""
            + "\"Shh... Don't even say his name. You don't want his help. (...) No, you don't. He does not work well with others. (...) I didn't want to bring it up, but rather than have you stumble on to it and make another mistake, I'll tell you. He was my assistant, but he was a troublemaker. Went out on his own as a freelance bio-exorcist. Claimed he could get rid of the living. Got into more trouble. In fact, I believe he's been sleazing around your cemetery lately. The only way he can be brought back is by calling his name three times.\"";
        // Otho character...
        String OFBio =
            "(by: Various, Beetlejuice Wikia)\n\n"
            + "Otho Fenlock is friends with Delia Deetz. He has a background of an Interior Design, is skilled in chemistry and served briefly as a 'hair analyst' and also knows a little in paranormal matters and was a top 'Paranormal Researcher' until the 'bottom dropped out' back in the 70's.\n\n"
            + "Otho's personality is grumpy when he hears things like ghosts in the house or he will have a bothered pesonality. Otho is also very clever when he helps other people in the house.\n\n"
            + "During the scene before the ending when he is revealing the ghosts and Betelgeuse arrives to save the Maitlands (Adam and Barbara), he is scared and embarrassed when Betlegeuse jumps on his back and makes his clothes rip into a leisure suit and then he leaves for good.";
        String OFQuo = "\"I know just as much about the supernatural as I do about interior design.\"\n\n";
        String OFBioQuo = "\"[Seeing an office and not seeing Barbara decapitating Adam.] Ugh. Deliver me from L.L. Bean.\"\n\n"
            + "\"[While Lydia shows them the attic.] Fabulous. 'Otho Fenlock's Locked Door Ghosts' Probably committed suicide up there. I'm totally enchanted.\"\n\n"
            + "\"Don't mind her. She's still upset, because somebody dropped a house on her sister.\"\n\n"
            + "\"Oh, you family types, you got other things to worry about. Maxie Dean's coming up here tonight. You got to figure out a way to sell these ghosts. I can only do so much.\"\n\n"
            + "\"I have a feeling there's something very interesting behind that door.\"\n\n";
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Beetlejuice")
            {
                tabPage1.BackgroundImage = null;
                tabPage2.BackgroundImage = null;
                label1.Text = BJBio;
                label2.Text = BJQuo;
                label3.Text = BJBioQuo;
                pictureBox1.ImageLocation = "C:\\Users\\triosStudent\\Documents\\Visual Studio 2015\\Projects\\Betelgeuse\\Betelgeuse\\images\\Beetlejuice.jpg";
                //pictureBox1.ImageLocation = "C:\\Users\\Thomas\\Documents\\Visual Studio 2015\\Projects\\Betelgeuse\\Betelgeuse\\images\\Beetlejuice.jpg";
            }
            else if (comboBox1.Text == "Lydia Deetz")
            {
                tabPage1.BackgroundImage = null;
                tabPage2.BackgroundImage = null;
                label1.Text = LDBio;
                label2.Text = LDQuo;
                label3.Text = LDBioQuo;
                pictureBox1.ImageLocation = "C:\\Users\\triosStudent\\Documents\\Visual Studio 2015\\Projects\\Betelgeuse\\Betelgeuse\\images\\Lydia.jpg";
                //pictureBox1.ImageLocation = "C:\\Users\\Thomas\\Documents\\Visual Studio 2015\\Projects\\Betelgeuse\\Betelgeuse\\images\\Lydia.jpg";
            }
            else if (comboBox1.Text == "Adam Maitland")
            {
                tabPage1.BackgroundImage = null;
                tabPage2.BackgroundImage = null;
                label1.Text = AMBio;
                label2.Text = AMQuo;
                label3.Text = AMBioQuo;
                pictureBox1.ImageLocation = "C:\\Users\\triosStudent\\Documents\\Visual Studio 2015\\Projects\\Betelgeuse\\Betelgeuse\\images\\Adam.jpg";
                //pictureBox1.ImageLocation = "C:\\Users\\Thomas\\Documents\\Visual Studio 2015\\Projects\\Betelgeuse\\Betelgeuse\\images\\Adam.jpg";
            }
            else if (comboBox1.Text == "Barbara Maitland")
            {
                tabPage1.BackgroundImage = null;
                tabPage2.BackgroundImage = null;
                label1.Text = BMBio;
                label2.Text = BMQuo;
                label3.Text = BMBioQuo;
                pictureBox1.ImageLocation = "C:\\Users\\triosStudent\\Documents\\Visual Studio 2015\\Projects\\Betelgeuse\\Betelgeuse\\images\\Barbara.jpg";
                //pictureBox1.ImageLocation = "C:\\Users\\Thomas\\Documents\\Visual Studio 2015\\Projects\\Betelgeuse\\Betelgeuse\\images\\Barbara.jpg";
            }
            else if (comboBox1.Text == "Charles Deetz")
            {
                tabPage1.BackgroundImage = null;
                tabPage2.BackgroundImage = null;
                label1.Text = CDBio;
                label2.Text = CDQuo;
                label3.Text = CDBioQuo;
                pictureBox1.ImageLocation = "C:\\Users\\triosStudent\\Documents\\Visual Studio 2015\\Projects\\Betelgeuse\\Betelgeuse\\images\\Charles.jpg";
                //pictureBox1.ImageLocation = "C:\\Users\\Thomas\\Documents\\Visual Studio 2015\\Projects\\Betelgeuse\\Betelgeuse\\images\\Charles.jpg";
            }
            else if (comboBox1.Text == "Delia Deetz")
            {
                tabPage1.BackgroundImage = null;
                tabPage2.BackgroundImage = null;
                label1.Text = DDBio;
                label2.Text = DDQuo;
                label3.Text = DDBioQuo;
                pictureBox1.ImageLocation = "C:\\Users\\triosStudent\\Documents\\Visual Studio 2015\\Projects\\Betelgeuse\\Betelgeuse\\images\\Delia.jpg";
                //pictureBox1.ImageLocation = "C:\\Users\\Thomas\\Documents\\Visual Studio 2015\\Projects\\Betelgeuse\\Betelgeuse\\images\\Delia.jpg";
            }
            else if (comboBox1.Text == "Juno")
            {
                tabPage1.BackgroundImage = null;
                tabPage2.BackgroundImage = null;
                label1.Text = JBio;
                label2.Text = JQuo;
                label3.Text = JBioQuo;
                pictureBox1.ImageLocation = "C:\\Users\\triosStudent\\Documents\\Visual Studio 2015\\Projects\\Betelgeuse\\Betelgeuse\\images\\Juno.jpg";
                //pictureBox1.ImageLocation = "C:\\Users\\Thomas\\Documents\\Visual Studio 2015\\Projects\\Betelgeuse\\Betelgeuse\\images\\Juno.jpg";
            }
            else if (comboBox1.Text == "Otho")
            {
                tabPage1.BackgroundImage = null;
                tabPage2.BackgroundImage = null;
                label1.Text = OFBio;
                label2.Text = OFQuo;
                label3.Text = OFBioQuo;
                pictureBox1.ImageLocation = "C:\\Users\\triosStudent\\Documents\\Visual Studio 2015\\Projects\\Betelgeuse\\Betelgeuse\\images\\Otho.jpg";
                //pictureBox1.ImageLocation = "C:\\Users\\Thomas\\Documents\\Visual Studio 2015\\Projects\\Betelgeuse\\Betelgeuse\\images\\Otho.jpg";
            }
            else
            {
                tabPage1.BackgroundImage = null;
                tabPage2.BackgroundImage = null;
                label1.Text = null;
                label2.Text = "\"See the Betelquotes tab for film info...\"";
                label3.Text = Data;
                pictureBox1.ImageLocation = "C:\\Users\\triosStudent\\Documents\\Visual Studio 2015\\Projects\\Betelgeuse\\Betelgeuse\\images\\HereLies.jpg";
                //pictureBox1.ImageLocation = "C:\\Users\\Thomas\\Documents\\Visual Studio 2015\\Projects\\Betelgeuse\\Betelgeuse\\images\\HereLies.jpg";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\triosStudent\\Documents\\Visual Studio 2015\\Projects\\Betelgeuse\\Betelgeuse\\images\\Cover.jpg";
            //pictureBox1.ImageLocation = "C:\\Users\\Thomas\\Documents\\Visual Studio 2015\\Projects\\Betelgeuse\\Betelgeuse\\images\\Cover.jpg";
            pictureBox2.ImageLocation = "C:\\Users\\triosStudent\\Documents\\Visual Studio 2015\\Projects\\Betelgeuse\\Betelgeuse\\images\\Logo.jpg";
            //pictureBox2.ImageLocation = "C:\\Users\\Thomas\\Documents\\Visual Studio 2015\\Projects\\Betelgeuse\\Betelgeuse\\images\\Logo.jpg";
            pictureBox3.ImageLocation = "C:\\Users\\triosStudent\\Documents\\Visual Studio 2015\\Projects\\Betelgeuse\\Betelgeuse\\images\\Logo.jpg";
            //pictureBox3.ImageLocation = "C:\\Users\\Thomas\\Documents\\Visual Studio 2015\\Projects\\Betelgeuse\\Betelgeuse\\images\\Logo.jpg";
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show
            ("\"Shake, shake, shake, Senora, shake your body line!\n"
            + "Shake, shake, shake, Senora, shake it all the time!\"\n\n"
            + "Psst, wanna' watch that video?",
            "The End?!",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation)
            == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://youtu.be/ic87SfqQAAM");
            }
        }
    }
}