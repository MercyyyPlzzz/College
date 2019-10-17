/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package objectorienteddesignpatterns.observer.task1;

/**
 *
 * @author k00220137
 */
public class ObserverImpl implements Observer {

    @Override
    public void update(String update) {
        System.out.println("Weather Live. "+update);
    }
    
}
