namespace SportsEventsApp.Constants
{
    //here are all the constants for the models in the db
    public class ModelConstants
    {
        public const int maxFightTitleLenght = 200;
        public const int minFightTitleLenght = 10;

        public const int maxFightDescLenght = 500;
        public const int minFightDescLenght = 20;

        public const int minFighterFirstNameLenght = 5;
        public const int maxFighterFirstNameLenght = 200;
        public const int minFighterLastNameLenght = 5;
        public const int maxFighterLastNameLenght = 200;
        public const int minFighterNickNameLenght = 5;
        public const int maxFighterNickNameLenght = 200;

        //not a url really, just a default pic
        public const string DefaultImageUrl = "/images/default-fight.jpg";

        public const int minFighterViewModelNameLength = 2;
        public const int maxFighterViewModelNameLength = 50;
    }
}
