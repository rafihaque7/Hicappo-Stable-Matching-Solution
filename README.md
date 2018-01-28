# Hicappo Stable Matching Solution
An implementation of Gale Shapeley's stable marriage algorithm using C#.

**What does the program do?**
>  Create a heterosexual stable matching pairs given names and preferences

**What even is Stable matching?**
> https://www.youtube.com/watch?v=Qcv1IqHWAzg

**How do I download the application?**

> https://github.com/rafihaque7/Hicappo-Stable-Matching-Solution/blob/master/StableMarriage/bin/Debug/StableMarriage.exe


![main](https://user-images.githubusercontent.com/23375929/35476695-302fedfc-0369-11e8-95f9-a74716f6293c.PNG)

## How does the matching algorithm work?
```C#
        void stableMatch()
        {
            int n = halfCount; //How many men or women?

            Queue<int> menQueue = new Queue<int>();
            LinkedList<int>[] menList = new LinkedList<int>[n];


            for (int i = 0; i < n; i++)
            {
                menQueue.Enqueue(i);
                menList[i] = new LinkedList<int>();
                for (int j = 0; j < n; j++)
                {
                    menList[i].AddLast(menPref[i, j]);
                }
            }


            engagedMen = Enumerable.Repeat(-1, n).ToArray();
            engagedWomen = Enumerable.Repeat(-1, n).ToArray();
            int totalProposed = 0;
            int posTotalProposed = n * n;


            while (menQueue.Count != 0 && totalProposed != posTotalProposed)
            {
                int m = menQueue.Dequeue();
                int w = menList[m].First();
                menList[m].RemoveFirst();


                if (engagedWomen[w] == -1)
                {
                    totalProposed++;
                    engagedMen[m] = w;
                    engagedWomen[w] = m;
                }
                else if (womenPref[w, m] < womenPref[w, engagedWomen[w]])
                {
                    int oldGuy = engagedWomen[w];
                    menQueue.Enqueue(oldGuy);
                    engagedMen[oldGuy] = -1;

                    totalProposed++;
                    engagedMen[m] = w;
                    engagedWomen[w] = m;
                }
                else
                {
                    totalProposed++;
                    menQueue.Enqueue(m);
                }
            }
        }
```



