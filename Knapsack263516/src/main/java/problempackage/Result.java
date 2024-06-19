package problempackage;

import java.util.ArrayList;
import java.util.List;

public class Result {
    private List<Item> result;
    private int totalValue;
    private int totalWeight;

    public Result() {
        this.result = new ArrayList<>();
        this.totalValue = 0;
        this.totalWeight = 0;
    }

    public int getTotalValue() {
        return totalValue;
    }

    public int getTotalWeight() {
        return totalWeight;
    }

    public List<Item> getItem() {
        return result;
    }

    public void addItem(Item item) {
        result.add(item);
        totalValue += item.getValue();
        totalWeight += item.getWeight();
    }

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < result.size(); i++) {
            sb.append(result.get(i) + "\n");
        }
        sb.append("Weight: " + totalWeight + "\n");
        sb.append("Value: " + totalValue + "\n");
        return sb.toString();
    }
}

