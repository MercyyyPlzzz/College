/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package objectorienteddesignpatterns.observer.task2;

/**
 *
 * @author James
 */
public class MoodleObserverExample {
    
    public static void main(String args[]){
       MoodlePage reactiveSystemsMoodlePage = new MoodlePage();
        
        Student s1 = new StudentImp1("K001d@lit.ie");
        Student s2 = new StudentImp1("K002@lit.ie");
        Student s3 = new StudentImp1("K003@lit.ie");
        
        reactiveSystemsMoodlePage.registerObserver(s1);
        reactiveSystemsMoodlePage.registerObserver(s2);
        reactiveSystemsMoodlePage.registerObserver(s3);
        
        
        MoodleUpdate update1 = new MoodleUpdate(MoodleUpdateType.ASSIGNMENT, "New Assignment!");
        reactiveSystemsMoodlePage.addPost(update1);
        
        reactiveSystemsMoodlePage.unRegisterObserver(s2);
        
        MoodleUpdate update2 = new MoodleUpdate(MoodleUpdateType.MESSAGE, "You all passed");
        reactiveSystemsMoodlePage.addPost(update2);
    }
}
