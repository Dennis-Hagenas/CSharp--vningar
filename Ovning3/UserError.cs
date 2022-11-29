namespace Ovning3
{
    public abstract class UserError
    {

        public abstract string UEMessage();
    }

    public class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }


    public class NumericRangeInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric range that was out of bounds. This fired an error!";
        }
    }

    public class TextLengthInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a too long or too short text string. This fired an error!";
        }
    }
    public class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in numeric input field. This fired an error!";
        }
    }

    public class NumericSignInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a number with the wrong sign. This fired an error!";
        }
    }


}
