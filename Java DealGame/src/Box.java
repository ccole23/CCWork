
public class Box {
   
   public final double DELTA = 0.01;

    private double Value;
    
    private boolean isOpen;

    
    
    public Box (double value){
        if(value < DELTA){
            throw new IllegalArgumentException("Invalid value");
        }
        this.Value = value;
        this.isOpen = false;
    }
    public double getValue(){
        return Value;
    }
    
    public boolean isOpen() {
        if (isOpen == true){
            return true;
        } else return false;
    }
    public void open(){ 
        isOpen = true;
    }
    public boolean equals(Object o){
        if ( o instanceof Box ) {
            Box m = (Box) o;
            if (((m.isOpen() == true && isOpen() == true)|| (m.isOpen() == false && isOpen==false) && 
            (Math.abs(m.getValue() - Value) < DELTA))) {
                return true;
            } else return false; 
            
            
        } else return false;
    }        
    public String toString() {
        String s = ("Open: " + isOpen + " Value: " + Value);
        return s;
    }
}   