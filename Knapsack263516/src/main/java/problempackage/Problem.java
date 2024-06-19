package problempackage;
import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class Problem {
    private int n;
    private int seed;
    private int lowerBoundProblem;
    private int upperBoundProblem;
    private List<Item> items;

    public Problem (List<Item> items){
        this.items = items;
        this.n = 0;
        this.seed = 0;
        this.lowerBoundProblem = 0;
        this.upperBoundProblem = 0;
    }
    public Problem(int n, int seed, int lowerBound, int upperBound) {
        this.n = n;
        this.seed = seed;
        this.lowerBoundProblem = lowerBound;
        this.upperBoundProblem = upperBound;
        this.items = new ArrayList<>();

        Random random = new Random(seed);

        for (int i = 1; i <= n; i++) {
            int index = i;
            int waga = random.nextInt(upperBound - lowerBound + 1) + lowerBound;
            int wartosc = random.nextInt(upperBound - lowerBound + 1) + lowerBound;
            items.add(new Item(index, waga, wartosc));
        }
    }

    public List<Item> getItems() {
        return items;
   }

    public Result solve(int capacity) {
        List<Item> sortedItems = new ArrayList<>(items);
        sortedItems.sort((item1, item2) -> Double.compare((double) item2.getValue() / item2.getWeight(), (double) item1.getValue() / item1.getWeight()));
//        System.out.println("-------------");
//        StringBuilder sb = new StringBuilder();
//        for (int i = 0; i < sortedItems.size(); i++) {
//            sb.append("No: [" + sortedItems.get(i).getIndex() + "] v: " + sortedItems.get(i).getWartosc() + " w: " + sortedItems.get(i).getWaga() + "\n");
//        }
//        System.out.println(sb);
        Result result = new Result();
        int remainingCapacity = capacity;

        for (int i = 0; i < sortedItems.size() && remainingCapacity > 0; i++) {
            Item item = sortedItems.get(i);

            if (item.getWeight() <= remainingCapacity) {
                int count = remainingCapacity / item.getWeight();
                for (int j = 0; j < count; j++) {
                    result.addItem(item);
                }
                remainingCapacity -= count * item.getWeight();
            }
        }

        return result;
    }
    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < items.size(); i++) {
                sb.append(items.get(i)+ "\n");
        }
        return sb.toString();
    }
}

