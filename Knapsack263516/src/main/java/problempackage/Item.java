package problempackage;

public class Item {
    private int index;
    private int weight;
    private int value;

    public Item(int index, int weight, int value) {
        this.index = index;
        this.weight = weight;
        this.value = value;
    }

    public int getWeight() {
        return weight;
    }

    public int getValue() {
        return value;
    }
//    public int getIndex() {
//        return index;
//    }

    @Override
    public String toString() {
        return "No: [" + index + "] v: " + value + " w: " + weight;
    }
}

