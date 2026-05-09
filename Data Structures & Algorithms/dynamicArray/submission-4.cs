public class DynamicArray {
    private int[] arr;
    private int capa = 0;
    private int size = 0;
    public DynamicArray(int capacity) {
        arr = new int[capacity];
        capa = capacity;
        for(int i = 0; i < size; i++){
            arr[i] = 0;
            size++;
        }
    }

    public int Get(int i) {
        return arr[i];
    }

    public void Set(int i, int n) {
        arr[i] = n;
    }

    public void PushBack(int n) {
        if(size >= capa){
            Resize();
        }
        arr[size] = n;
        size++;
    }

    public int PopBack() {
        int temp = size-1;
        size--;
        return arr[temp];
    }

    private void Resize() {
        int[] newarray = new int[capa*2];
        capa *= 2;
        Array.Copy(arr,newarray,size);
        arr = newarray;
    }

    public int GetSize() {
        return size;
    }

    public int GetCapacity() {
        return capa;
    }
}
