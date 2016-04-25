import junit.framework.TestCase;

public class BowlingTestJunit extends TestCase {

    private Game g;
    
    public void setUp()
    {
        g = new Game();
    }
    
    public void testGutterGame()
    {
        rollMany(20, 0);
        assertEquals(0, g.getScore());
    }
    
    public void testAllOnes()
    {
        rollMany(20, 1);
        assertEquals(20, g.getScore());
    }

    private void rollMany(int n, int pins)
    {
        for(int i =0; i < n; i++)
        {
            g.roll(pins);
        }
    }

    
    public void testOneSpare()
    {
        rollSpare();
        g.roll(3);
        rollMany(17, 0);
        assertEquals(16, g.getScore());
    }

    private void rollSpare()
    {
        g.roll(5);
        g.roll(5);
    }

    
    public void testOneStrike()
    {
        rollStrike();
        g.roll(3);
        g.roll(4);
        rollMany(16, 0);
        assertEquals(24, g.getScore());
    }

    
    public void testPerfectGame()
    {
        rollMany(12,10);
        assertEquals(300, g.getScore());
    }

    private void rollStrike()
    {
        g.roll(10);
    }
}


