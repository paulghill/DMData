using System.Collections.Generic;

namespace DMData.Names
{
    static class DataTitles
    {
        public static IReadOnlyList<TitleGroup> GetTitleData()
        {
            return new List<TitleGroup>()
            {
                new TitleGroup(TitleCategoryType.Academics, new List<Title>()
                {
                    new Title(NameGenderType.Unisex, "Assistant Professor", "A junior professor, below an associate professor."),
                    new Title(NameGenderType.Unisex, "Associate Professor", "A senior professor."),
                    new Title(NameGenderType.Unisex, "Jiàoshòu", "Professor."),
                    new Title(NameGenderType.Unisex, "Laoshi", "Teacher."),
                    new Title(NameGenderType.Unisex, "Professor", "A teacher of the highest ranks, an expert in a field of study."),
                    new Title(NameGenderType.Unisex, "Rector", "A senior offical in an acedamic institution."),
                    new Title(NameGenderType.Unisex, "Xiàozhang", "School headmaster."),
                }),
                new TitleGroup(TitleCategoryType.Clan, new List<Title>()
                {
                    new Title(NameGenderType.Unisex, "Pursuivant", "Historians that look after matters of heraldic and genealogical importance for clan members."),
                    new Title(NameGenderType.Unisex, "Starosta", "Community elder that administers clan or family assets."),
                }),
                new TitleGroup(TitleCategoryType.Government, new List<Title>()
                {
                    new Title(NameGenderType.Unisex, "Aesymnetes", "A tyrant."),
                    new Title(NameGenderType.Unisex, "Agoranomos", "Overseer of a market place."),
                    new Title(NameGenderType.Female, "Anassa", "Queen."),
                    new Title(NameGenderType.Male, "Anax", "King."),
                    new Title(NameGenderType.Unisex, "Apostle", "A messenger, ambassador, emissary, or envoy of a government."),
                    new Title(NameGenderType.Unisex, "Archon", "Head of a specific office.  Also denotes a ruler. "),
                    new Title(NameGenderType.Female, "Augusta", "Female of imperial families of highest honor.  Title bestowed right to issue own coins and hold courts."),
                    new Title(NameGenderType.Male, "Augustus", "Male of imperial families of highest honor.  Title bestowed right to issue own coins and hold courts."),
                    new Title(NameGenderType.Female, "Basileia", "Queen."),
                    new Title(NameGenderType.Male, "Basileus", "King."),
                    new Title(NameGenderType.Unisex, "Chancellor", "Can refer to a head of government, head of foreign affirs, a person with duties of justice, a finance minster."),
                    new Title(NameGenderType.Unisex, "Constable", "Generally denoting a member of law enforcement."),
                    new Title(NameGenderType.Unisex, "Councillor", "A member of local government."),
                    new Title(NameGenderType.Male, "Daimyo", "Powerful Japanese feudal samurai under the shogun."),
                    new Title(NameGenderType.Unisex, "Desai", "Title given to feudal lords that reside over a village or a group of villages."),
                    new Title(NameGenderType.Male, "Emir", "Prince or king.  Kingdom is an emirate."),
                    new Title(NameGenderType.Female, "Emira", "Princess or queen."),
                    new Title(NameGenderType.Unisex, "Exarch", "Imperial governor of a large and important region of the empire."),
                    new Title(NameGenderType.Unisex, "Foreign Minister", "Head of foreign affirs in a cabinent."),
                    new Title(NameGenderType.Unisex, "Governor", "A head of territory or state that is part of a larger government body."),
                    new Title(NameGenderType.Unisex, "Herald", "Messanger or ambassador for a monarch."),
                    new Title(NameGenderType.Male, "Karo", "Samauri advisors and officials to the daimyos."),
                    new Title(NameGenderType.Male, "Khan", "Simliar to emperor."),
                    new Title(NameGenderType.Female, "Khatan", "Similar to empress."),
                    new Title(NameGenderType.Unisex, "Kolakretai", "Similar to a finance minister that managed all finance matters for a king."),
                    new Title(NameGenderType.Male, "Malek", "Similar to king."),
                    new Title(NameGenderType.Male, "Malick", "Similar to king."),
                    new Title(NameGenderType.Male, "Malik", "Similar to king."),
                    new Title(NameGenderType.Male, "Malka", "Similar to king."),
                    new Title(NameGenderType.Unisex, "Mayor", "Head of a local government."),
                    new Title(NameGenderType.Male, "Melekh", "Similar to king."),
                    new Title(NameGenderType.Male, "Melik", "Similar to king."),
                    new Title(NameGenderType.Unisex, "Nomarch", "Governor."),
                    new Title(NameGenderType.Unisex, "Palatine", "An official attached to imperial or royal courts."),
                    new Title(NameGenderType.Unisex, "Patroon", "Landholder of a manor. Similar to a Baron/Baroness."),
                    new Title(NameGenderType.Unisex, "President", "Head of a government body.  Also can refer to the head of an instution."),
                    new Title(NameGenderType.Unisex, "Prime Minister", "Head of cabinent and ministers.  Is not head of government and servers under a monarch or president."),
                    new Title(NameGenderType.Male, "Roju", "An elder in a Shogunate, one of the highest ranking positions."),
                    new Title(NameGenderType.Male, "Shogun", "Military dictator."),
                    new Title(NameGenderType.Unisex, "Taoiseach", "An appointed prime minster."),
                    new Title(NameGenderType.Male, "Thakur", "Male owner of a princely state called a Thakurate."),
                    new Title(NameGenderType.Female, "Thakurani", "Female owner of a princely state called a Thakurate."),
                    new Title(NameGenderType.Unisex, "Tyrant", "An absolute ruler unbound by law."),
                    new Title(NameGenderType.Unisex, "Zamindar", "Land owner of large tracts of land and peasants."),
                }),
                new TitleGroup(TitleCategoryType.Institutional, new List<Title>()
                {
                    new Title(NameGenderType.Male, "Chairman", "Presiding man of an organized group."),
                    new Title(NameGenderType.Female, "Chairperson", "Presiding person of an organized group."),
                    new Title(NameGenderType.Female, "Chairwoman", "Presiding woman of an organized group."),
                    new Title(NameGenderType.Male, "Grand Master", "Male head of an institution."),
                    new Title(NameGenderType.Female, "Grand Mistress", "Female head of an institution."),
                }),
                new TitleGroup(TitleCategoryType.Medical, new List<Title>()
                {
                    new Title(NameGenderType.Unisex, "Archiater", "Chief doctor of a monarch."),
                    new Title(NameGenderType.Unisex, "Doctor", "Medical expert or a person that holds a doctorates."),
                    new Title(NameGenderType.Unisex, "Nurse", "A person trained to care for the sick or infirm."),
                    new Title(NameGenderType.Unisex, "Witch Doctor", "A healer of ailments caused by witchcraft.  A tribal healer."),
                    new Title(NameGenderType.Unisex, "Yisheng", "Medical scholar."),
                    new Title(NameGenderType.Unisex, "Yishi", "Medical master."),
                }),
                new TitleGroup(TitleCategoryType.Military, new List<Title>()
                {
                    new Title(NameGenderType.Male, "Praetor", "Appointed commander of an army."),
                }),
                new TitleGroup(TitleCategoryType.Religious, new List<Title>()
                {
                    new Title(NameGenderType.Unisex, "Apostle", "A messenger, emissary, or envoy of a religion."),
                    new Title(NameGenderType.Male, "Arcpriest", "High ranking priest."),
                    new Title(NameGenderType.Female, "Arcpriestess", "High ranking priestess."),
                    new Title(NameGenderType.Male, "Brother", "A male religious leader engaged in ministry and works of mercy."),
                    new Title(NameGenderType.Unisex, "Grand Inquisitor", "Head of an inquistion to read a territory of heresy."),
                    new Title(NameGenderType.Unisex, "Hieromonk", "A priest that is also a monk."),
                    new Title(NameGenderType.Unisex, "Hierophant ", "An interpreter of sacred mysteries and arcane principles"),
                    new Title(NameGenderType.Male, "High Priest", "Below an arcpriest but higher than a priest."),
                    new Title(NameGenderType.Female, "High Priestess", "Below an acrpriestess but higher than a priestess."),
                    new Title(NameGenderType.Unisex, "Inquisitor", "An official with judical rights to rid a territory of heresy."),
                    new Title(NameGenderType.Male, "Priest", "Religious leader."),
                    new Title(NameGenderType.Female, "Priestess", "Religious leader."),
                    new Title(NameGenderType.Unisex, "Shaman", "Spiritual leader that interacts with the spirit world and its energies."),
                    new Title(NameGenderType.Female, "Sibyl", "A female oracle."),
                    new Title(NameGenderType.Female, "Sister", "A female religious leader engaged in ministry and works of mercy."),
                }),
                new TitleGroup(TitleCategoryType.Social, new List<Title>()
                {
                    new Title(NameGenderType.Unisex, "Choregos", "A wealthy patron of arts that financied public performances."),
                    new Title(NameGenderType.Male, "Don", "A male person of social distinction."),
                    new Title(NameGenderType.Female, "Doña", "A female person of social distinction."),
                    new Title(NameGenderType.Unisex, "Furén", "Female of high rank."),
                    new Title(NameGenderType.Female, "Hidalga", "A female citizen of the state afforded some rights as nobles such as bear arms and freedom of taxation."),
                    new Title(NameGenderType.Male, "Hidalgo", "A male citizen of the state afforded some rights as nobles such as bear arms and freedom of taxation."),
                    new Title(NameGenderType.Female, "Lady", "Female of high social status"),
                    new Title(NameGenderType.Male, "Lord", "Male of high social status"),
                    new Title(NameGenderType.Unisex, "Sri", "A person of high wealth."),
                }),
                new TitleGroup(TitleCategoryType.Tribe, new List<Title>()
                {
                    new Title(NameGenderType.Unisex, "Agha", "Leader of a tribe."),
                    new Title(NameGenderType.Unisex, "Apodektai", "A tribal tax collector."),
                    new Title(NameGenderType.Unisex, "Chief", "Leader of a tribe."),
                    new Title(NameGenderType.Unisex, "Chieftain", "Leader of a tribe."),
                    new Title(NameGenderType.Unisex, "Elder", "Leader of a tribe, or part of a council that leads a tribe (elders)."),
                    new Title(NameGenderType.Male, "Naib", "Leader of a tribe."),
                    new Title(NameGenderType.Male, "Sheikh", "Male tribal leader."),
                    new Title(NameGenderType.Female, "Sheikha", "Female tribal leader."),
                }),
            };
        }
    }
}
