namespace EvilNumbers
{
    public class EvilThings{
        public static bool IsEvilNumberStatic (short value) {
            short numberOf1 = 0;
            byte position = default;
            byte valueByte = (byte)value;
            for (var i=0; i< 8; i++) {
                if (position == default) {
                    position = 0b00000001;
                } else {
                    position = (byte)(position << 1);
                }
                if((position & valueByte) > 0){
                    numberOf1 ++;
                }
            }
            if (numberOf1%2 == 0) {
                return true;
            }
            return false;
        }
        public bool IsEvilNumber (short value) {
            return IsEvilNumberStatic(value);
        }
    }
}
