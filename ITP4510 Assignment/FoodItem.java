public class FoodItem {
    private String name;
    private int cookTime;
    private int remainCookTime;

    public FoodItem(String name) {
        this.name = name;
    }

    public FoodItem(String name, int cookTime) {
        this.name = name;
        this.cookTime = cookTime;
        this.remainCookTime = cookTime;
    }

    public String getName() {
        return name;
    }

    public int getRemainCookTime() {
        return remainCookTime;
    }

    public void reduceCookTime() {
        remainCookTime--;
    }

    public String toString() {
        return "(" + name + " " + remainCookTime + ")";
    }

}