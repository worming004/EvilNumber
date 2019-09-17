namespace EvilNumbers
{
    public class EvilThings{
        static 
        byte[] positions = {
            0b00000001,
            0b00000010,
            0b00000100,
            0b00001000,
            0b00010000,
            0b00100000,
            0b01000000,
            0b10000000
        };
        public static bool IsEvilNumberStatic (short value) {
            short numberOf1 = 0;
            byte valueByte = (byte)value;
            foreach(byte position in positions){
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