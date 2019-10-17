/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package objectorienteddesignpatterns.observer.task1;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author k00220137
 */
class MetEireannSubject {
    List<Observer> observerList;
    
    public MetEireannSubject()
    {
        observerList=new ArrayList();
    }
    
    public void setWeather(String bright_and_sunny_Go_Outside) {
       boolean flag = true;
       while (flag)
       {
           String newInfo = bright_and_sunny_Go_Outside;
           if(newInfo.equals("Raining Heavily!.. Stay Inside"))
           {
               flag = false;
           }
           notifyObservers(newInfo);
       }
    }
    
    public boolean addObserver(Observer newObserver)
    {
        return observerList.add(newObserver);
    }
    
    public boolean deleteObserver(Observer oldObserver)
    {
        return observerList.remove(oldObserver);
    }
    
    public void notifyObservers(String update)
    {
        for (Observer obs : observerList)
        {
            obs.update(update);
        }
    }

        
}
