/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package oo_design_patterns_ca.observer2;

/**
 *
 * @author James
 */
public class StackOverFlowTagExample {
    
    public static void main(String args[]){
        StackOverFlowTag javaTag = new StackOverFlowTag("Java");
        StackOverFlowTag scalaTag = new StackOverFlowTag("Scala");
        
        Developer custJohn = new Developer("John@ILikeJava.ie");
        Developer custLuke = new Developer("Luke@youtube.ie");
        Developer custMark = new Developer("Mark@google.ie");
        
        javaTag.registerObserver(custJohn);
        javaTag.registerObserver(custLuke);
        javaTag.registerObserver(custMark);
       
        javaTag.addPost("Java12 now available! ");
        
        javaTag.unRegisterObserver(custLuke);
        scalaTag.registerObserver(custJohn);
        
        javaTag.addPost("Lambdas offer many functional features!");
        scalaTag.addPost("Scala is ACTUALLY functional");
    }
}
