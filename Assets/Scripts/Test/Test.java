import java.util.*;

class Solution {
    public int solution(int n, int[][] wires) {
        Map<Integer, List<Integer>> tree = new HashMap<>();
        Deque<Integer> queue = new ArrayDeque<>();
        int size = wires.length;
        int min = 100;

        // 와이어 다 연결시켜서 트리구조 만들기!
        for (int[] wire : wires)
        {
            if (tree.containsKey(wire[0]))
            {
                tree.get(wire[0]).add(wire[1]);
            }
            else
            {
                tree.put(wire[0], new ArrayList<Integer>()
                {
                    {
                        add(wire[1]);
                    }
                });
            }
        }

        // 모든 와이어를 순회하면서 하나씩 끊어주기!
        for (int[] wire : wires)
        {
            int leftCount = 0;
            int rightCount = 0;

            // 끊어진 왼쪽을 BFS로 순회하며 개수 확인하기
            queue.add(wire[0]);

            while (!queue.isEmpty()) {
                int temp = queue.remove();
                List<Integer> visited = new ArrayList<>() {
                    {
                        add(wire[1]);
                    }
                };

                for (int i : tree.get(temp)) {
                    if (!visited.contains(i)) {
                        queue.add(i);
                        visited.add(i);
                        ++leftCount;
                    }
                }
            }

            // 끊어진 오른쪽을 BFS로 순회하며 개수 확인하기
            queue.add(wire[1]);

            while (!queue.isEmpty()) {
                int temp = queue.remove();
                List<Integer> visited = new ArrayList<>() {
                    {
                        add(wire[0]);
                    }
                };

                for (int i : tree.get(temp))
                {
                    if (!visited.contains(i))
                    {
                        queue.add(i);
                        visited.add(i);
                        ++rightCount;
                    }
                }
            }

            // 오른쪽/왼쪽 개수를 빼서 최솟값이랑 비교하기!
            if (Math.abs(rightCount - leftCount) < min)
            {
                min = Math.abs(rightCount - leftCount);
            }
        }
        return min;
    }
}