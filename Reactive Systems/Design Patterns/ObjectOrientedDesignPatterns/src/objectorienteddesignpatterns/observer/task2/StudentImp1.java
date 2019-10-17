/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package objectorienteddesignpatterns.observer.task2;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author k00220137
 */
public class StudentImp1 implements Student {

    List<String> updatesList;
    
    StudentImp1(String kNum)
    {
        updatesList = new ArrayList();
        updatesList.add(kNum);
    }
    
    @Override
    public void update(MoodleUpdate update) {
        System.out.println(" received "+update.getTypeOfUpdate()+" notification | "+update.getDescription());
    }
    
    public List<String> getUpdatesList()
    {
        return updatesList;
    }
    
}
