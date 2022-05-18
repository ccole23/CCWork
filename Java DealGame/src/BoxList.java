import java.util.Random;
import java.util.Arrays;
public class BoxList {
    
    private Box[] boxes; 
     
    public BoxList(double[] monetaryAmounts){
        if (monetaryAmounts == null) {
                 throw new NullPointerException("Null monetary amounts");
             }
        boxes = new Box [monetaryAmounts.length];
        if (monetaryAmounts.length < 2){
                throw new IllegalArgumentException("Invalid monetary amounts");
        }
         
         for (int i =0; i < monetaryAmounts.length; i++){
                
             Box box = new Box (monetaryAmounts[i]);
             boxes[i]= box;
             
             
             
 
         }
    }
    public double getValue(int index){
        
       if (index < 0 || index >= boxes.length){
            throw new IllegalArgumentException("Invalid index");
       }
       return boxes[index].getValue();
        
        
        
    }
    public boolean isOpen(int index){
       if (index < 0 || index >= boxes.length){
            throw new IllegalArgumentException("Invalid index");
        } 
        if (boxes[index].isOpen() == true){
            
            return true;
        } else return false; 
    }
    public void open (int index) { 
        
       if (index < 0 || index >= boxes.length){
           throw new IllegalArgumentException("Invalid index");
        
        }
        boxes[index].open();
    }
    public double averageValueOfUnopenedBoxes(){
        double sum = 0; 
        int boxnumber = 0;
        for (int i = 0; i < boxes.length; i++){ 
            if (boxes[i].isOpen() == false){
                sum += boxes[i].getValue();
                ++boxnumber;
            }
        }
            if (boxnumber == 0){
              return 0;   
            } else return sum/boxnumber;
    }
   
   public void shuffle(int numberOfSwaps){
        if (numberOfSwaps < 0){
            throw new IllegalArgumentException("Invalid number of swaps");
        } else {
            Random ran = new Random();
            for (int i = 1; i <= numberOfSwaps; i++){
                int randomIndex = ran.nextInt(boxes.length);
                int randomIndex2 = ran.nextInt(boxes.length);
                Box val = boxes[randomIndex2];
                boxes[randomIndex2] = boxes[randomIndex];
                boxes[randomIndex] = val;
            
            }
        }
        }
    
    public boolean equals(Object o){
       Boolean answer = null;       
       if (o instanceof BoxList){
            BoxList test = (BoxList) o;
            if (Arrays.deepEquals(test)){
                answer = true;

            } else answer = false;
                
       }               
       System.out.println(answer);
        return answer;
     }

            
          
        
        
    
    public String toString(){
        String s = "";
        for (int i = 0; i < boxes.length; i++){
             s+= i + ": ";
             s += boxes[i].toString();
             s += "\n";
            
        }
        return s;
    }
      
    }
    