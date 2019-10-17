/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package observerex;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 *
 * @author k00220137
 */
public class Subject {
    List<Observer> observerList;
    Scanner in;
    
    public Subject()
    {
        observerList=new ArrayList();
        in = new Scanner(System.in);
    }
    
    public boolean registerObserver(Observer newObserver)
    {
        return observerList.add(newObserver);
    }
    
    public boolean unRegisterObserver(Observer oldObserver)
    {
        return observerList.remove(oldObserver);
    }
    
    public void notifyObservers(String update)
    {
        for(Observer obs:observerList)
        {
            obs.update(update);
        }
    }
    
    public void requestInput()
    {
        boolean flag= true;
        while (flag){
            System.out.println("Have you any info? ");
            String newInfo=in.nextLine();
            if(newInfo.equalsIgnoreCase("stop"))
            {
                flag = false;
            }
            notifyObservers(newInfo);
        }
    }
}
