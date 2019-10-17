/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package oo_design_patterns_ca.observer2;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author k00220137
 */

class StackOverFlowTag{
List<Observer> observerList;


    StackOverFlowTag(String name) {
       observerList = new ArrayList();
    }

    public boolean registerObserver(Observer newObserver) {
         return observerList.add(newObserver);
    }

    public boolean unRegisterObserver(Observer oldObserver) {
        return observerList.remove(oldObserver);
    }

    public void notifyObservers(String update) {
        for(Observer obs:observerList)
        {
            obs.update(update);
        }
    }
    
    public void addPost(String update)
    {
        notifyObservers(update);
    }


}
