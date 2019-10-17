/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package objectorienteddesignpatterns.observer.task1;

/**
 *
 * @author James
 */
public class ObserverExample {

    public static void main(String[] args) {
        MetEireannSubject subjectObs = new MetEireannSubject();
        Observer observerImp1 = new ObserverImpl();
        subjectObs.addObserver(observerImp1);
        subjectObs.setWeather("Bright and sunny... Go Outside");
        subjectObs.setWeather("Raining Heavily!.. Stay Inside");
    }
}
