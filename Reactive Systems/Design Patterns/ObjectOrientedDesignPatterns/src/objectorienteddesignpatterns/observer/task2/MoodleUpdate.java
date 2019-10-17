/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package objectorienteddesignpatterns.observer.task2;

/**
 *
 * @author James
 */
//OBJECT
enum MoodleUpdateType {
  ASSIGNMENT,
  SLIDES,
  MESSAGE
}

public class MoodleUpdate {
    MoodleUpdateType typeOfUpdate;
    String description; 

    public MoodleUpdate(MoodleUpdateType typeOfUpdate, String description) {
        this.typeOfUpdate = typeOfUpdate;
        this.description = description;
    }

    public MoodleUpdateType getTypeOfUpdate() {
        return typeOfUpdate;
    }

    public String getDescription() {
        return description;
    }

}
