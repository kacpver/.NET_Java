package problempackage;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

import java.util.ArrayList;
import java.util.List;

import static org.junit.jupiter.api.Assertions.*;

class ProblemTest {
    @Test
    public void minOneGoodElement() {
        List<Item> items = new ArrayList<>();
        for (int i = 1; i <= 10; i++) {
            items.add(new Item(i,5,i));
        }
        Problem testProblem = new Problem(items);
        Result result = testProblem.solve(20);
        Assertions.assertTrue(0<result.getItem().size());
    }
    @Test
    public void zeroGoodElement() {
        List<Item> items = new ArrayList<>();
        for (int i = 1; i <= 10; i++) {
            items.add(new Item(i,20,i));
        }
        Problem testProblem = new Problem(items);
        Result result = testProblem.solve(10);
        Assertions.assertEquals(0,result.getItem().size());
    }

    @Test
    public void valueAndWeightGood() {
        Problem problem = new Problem(10, 2, 1, 10);
        boolean test;
        for (int i = 1; i < 10; i++) {
        Assertions.assertTrue((1<=problem.getItems().get(i).getWeight())&(10>=problem.getItems().get(i).getWeight()));
        Assertions.assertTrue((1<=problem.getItems().get(i).getValue())&(10>=problem.getItems().get(i).getValue()));
        }

    }
    @Test
    public void totalvalueAndWeightGood() {
        List<Item> items = new ArrayList<>();
        for (int i = 1; i <= 10; i++) {
            items.add(new Item(i,5,i));
        }
        items.add(new Item(1,1,1));
        Problem testProblem = new Problem(items);
        Result result = testProblem.solve(21);
        Assertions.assertEquals(21,result.getTotalWeight());
        Assertions.assertEquals(41,result.getTotalValue());
    }

}