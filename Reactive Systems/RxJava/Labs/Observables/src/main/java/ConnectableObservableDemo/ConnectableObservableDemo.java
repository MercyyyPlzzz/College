/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ConnectableObservableDemo;

import io.reactivex.Observable;
import io.reactivex.observables.ConnectableObservable;

/**
 *
 * @author Ken
 */
public class ConnectableObservableDemo {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        ConnectableObservable<String> source
                =Observable.just("Alpha","Beta","Gamma","Delta","Epsilon")
                        .publish();
        
        //Observer 1 Setup
        source.subscribe(s -> System.out.println("Observer 1: "+s));
        
        //Observer 2 Setup
        source.map(String::length)
                .subscribe(i -> System.out.println("Observer 2: "+i));
        
        //Fire!
        source.connect();
    }
    
}
