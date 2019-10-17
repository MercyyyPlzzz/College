/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Launcher;

import io.reactivex.Observable;

/**
 *
 * @author Ken
 */
public class Launcher {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       Observable<String> source = Observable.create(emitter ->{
           emitter.onNext("Alpha");
           emitter.onNext("Beta");
           emitter.onNext("Gamma");
           emitter.onNext("Delta");
           emitter.onNext("Epsilon");
           emitter.onComplete();
       });
    source.subscribe(s->System.out.println("Received: "+s));
}
}

