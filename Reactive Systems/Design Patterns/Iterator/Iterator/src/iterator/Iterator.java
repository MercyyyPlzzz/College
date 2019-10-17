/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.lit.reactivesystems.objectorienteddesignpatterns.iterator;

/**
 *
 * @author James
 */
public interface Iterator<E>
{
    E next();   // To get the next element
 
    boolean hasNext();  // To check whether there is any next element or not.
}