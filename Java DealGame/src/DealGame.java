import java.io.*;
import java.util.*;
public class DealGame {
  
  
  
    private BoxList boxList;
    
    private int boxesOpenedThisRound;
    
    private double highScore;
    
    private int playerBoxIndex;
    
    private boolean hasPlayerChosenBox;
    
    private int boxesOpenedTotal;
    
    private int round;
    
    
    
    /** Number of boxes in the game */
    public static final int NUM_BOXES = 26;
  
  
    /** Monetary values that will be used in the game */
    public static final double[] BOX_VALUES = {0.01, 1, 5, 10, 25, 50, 75, 
                                               100, 200, 300, 400, 500, 
                                               750, 1000, 5000, 10000, 
                                               25000, 50000, 75000, 
                                               100000, 200000, 300000, 
                                               400000, 500000, 750000, 
                                               1000000};
  
    /** Number of boxes to be opened in each round */
    public static final int[] BOXES_IN_ROUND = {0, 6, 5, 4, 3, 2, 
                                                1, 1, 1, 1, 1};
                                                
    /** Number of rounds in the game */
    public static final int NUM_ROUNDS = 10;
  
    /** Number of times boxes are swapped during the set up */
    public static final int BOX_SWAPS = 500;
  
    /** Name of the file that contains the high score */
    public static final String HIGH_SCORE_FILE = "highscore.txt";
    
    public DealGame(boolean testing){
       File f = new File (HIGH_SCORE_FILE);
       
       try {
           Scanner highfile = new Scanner(f);
           boxList = new BoxList(BOX_VALUES);
           if (testing == false){
               boxList.shuffle(BOX_SWAPS);
            }
            if (f.exists()){
                if (highfile.hasNextDouble()){
                    highScore = highfile.nextDouble();
                }else {
                    highScore = 0;
                
                }
            }
                this.round = 1;
                this.boxesOpenedThisRound = 0;
                
       } catch (FileNotFoundException e) {
           highScore = 0;
           
       }
       
    }
    public boolean hasPlayerChosenBox(){
        if (hasPlayerChosenBox == true){
            return true;
        } else return false;
    }
    
    public void selectBox(int index){
        if (hasPlayerChosenBox == false){
           playerBoxIndex = index;
           hasPlayerChosenBox = true;
        } else {
            boxList.open(index);
            
            boxesOpenedThisRound = boxesOpenedThisRound + 1;
            boxesOpenedTotal= boxesOpenedTotal + 1;
            getBoxesRemainingToOpenThisRound();

        }  
    }
    
    public int getBoxesRemainingToOpenThisRound(){
       int boxesLeft = 0;
       if (getRound() <= NUM_ROUNDS){
            boxesLeft = BOXES_IN_ROUND[getRound()] - boxesOpenedThisRound;
       }
       return boxesLeft;
    }
    
    public int getBoxesOpenedThisRound(){
        return boxesOpenedThisRound;

    }
    
    public int getRound(){
        return round;
    }
    
    
    public void startNextRound(){
        boxesOpenedThisRound = 0;        
        ++round;
    }
    public boolean isEndOfRound(){
        int boxesLeft = getBoxesRemainingToOpenThisRound();
        if (boxesLeft <= 0){
            return true;
        } else return false;
        
    }
    public double getPlayerBoxValue(){
        
        return boxList.getValue(playerBoxIndex);
    }
    
    public boolean isBoxOpen(int index){
        if (boxList.isOpen(index)){
            return true;
        } else return false;
    }
    public double getValueInBox(int index){
        return boxList.getValue(index);
    }
    public double getCurrentOffer(){
        double average = boxList.averageValueOfUnopenedBoxes();
        double offer = (average * round)/ 10;
        return offer;
    }
    
    public double getHighScore(){
        return highScore;
        
    }
    
    public boolean isNewHighScore(double value){
        
        try {
            PrintStream Output = new PrintStream(HIGH_SCORE_FILE);
            
            if (value > getHighScore()){
                Output.println(value);
                highScore = value;
                return true;
            
            } else {
          
                return false;
            }
        } catch(FileNotFoundException e) {
           return true;
            }
    }
    
    
    
    
    
}
