import java.awt.*;

public class virus {
    public static void Main() throws AWTException {
        Robot r = new Robot();
        while(true){
            r.keyPress(44);
            r.keyRelease(44);
            r.keyPress(45);
            r.keyRelease(45);
        }
    }
}
