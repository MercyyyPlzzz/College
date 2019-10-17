/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ColdObservable;

import io.reactivex.Observable;

/**
 *
 * @author Ken
 */
public class ColdObservable {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Observable<String> source
                =Observable.just("Alpha", "Beta", "Gamma", "Delta", "Epsilon");
        
        //First Observer
        source.subscribe(s -> System.out.println("Observer 1 Received: "+s));
        
        //Second Observer
        source.subscribe(s -> System.out.println("Observer 2 Received: "+s));
    }
    
}
