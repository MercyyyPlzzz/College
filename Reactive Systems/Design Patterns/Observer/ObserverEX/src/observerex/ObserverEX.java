/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package observerex;

/**
 *
 * @author k00220137
 */
public class ObserverEX {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        //Create console input subject
        Subject subj = new Subject();
        
        //Create observers
        Observer obs1 = new ConcObs1();
        Observer obs2= new ConcObs2();
        Observer obs3=new ConcObs1();
        Observer obs4 = new ConcObs3();
        
        //Register observers with the Subject
        subj.registerObserver(obs1);
        subj.registerObserver(obs2);
        subj.registerObserver(obs3);
        subj.registerObserver(obs4);
        
        //Start submitting text to generate update for the observers
        subj.requestInput();
        
        //Cast obs4 to ConcObs3 obbject to access the list getter
        ConcObs3 obs4ConcObs3 = (ConcObs3) obs4;
        
        //Print all updatees that occured
        System.out.println("Updates Stored in OBS4");
        obs4ConcObs3.getUpdateList().forEach(System.out::println);
    }
    
}
