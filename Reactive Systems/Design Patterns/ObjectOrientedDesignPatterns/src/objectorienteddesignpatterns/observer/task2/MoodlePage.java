/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package objectorienteddesignpatterns.observer.task2;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

/**
 *
 * @author k00220137
 */
//Subject
public class MoodlePage {
    List<Student> observerList;
    
    public MoodlePage()
    {
        observerList = new ArrayList();
    }
    
    public boolean registerObserver(Student newObserver)
    {
        return observerList.add(newObserver);
    }
    
    public boolean unRegisterObserver(Student oldObserver)
    {
        return observerList.remove(oldObserver);
    }
    
    public void notifyObservers(MoodleUpdate update)
    {      
        Iterator<Student> iter = observerList.iterator();
        
        while(iter.hasNext())
        {
            Student obs = iter.next();
            obs.update(update);
        }
    }

    public void addPost(MoodleUpdate update) {
        notifyObservers(update);
    }
}
