/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package LauncherObserver;

import io.reactivex.Observable;
import io.reactivex.Observer;
import io.reactivex.disposables.Disposable;

/**
 *
 * @author Ken
 */
public class LauncherObserver {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Observable<String> source
                =Observable.just("Alpha","Beta","Gamma","Delta","Epsilon");
        
        Observer<Integer> myObserver = new Observer<Integer>()
        {
            @Override
            public void onSubscribe(Disposable d)
            {
                
            }
            
            @Override
            public void onNext(Integer value)
            {
                System.out.println("Received: "+value);
            }
            
            @Override
            public void onError(Throwable e)
            {
                e.printStackTrace();
            }
            
            @Override
            public void onComplete()
            {
                System.out.println("Done!");
            }
        };
                
    }
    
}
