namespace LeetCode.Problems;

public class ReveserBits{
    public uint reverseBits(uint n) {
         string binary = Convert.ToString(n, 2).PadLeft(32, '0');
        
        char[] charArray = binary.ToCharArray();
        Array.Reverse( charArray );
        
        string reversed = new string(charArray);
        
        return Convert.ToUInt32(reversed, 2);
    }
}