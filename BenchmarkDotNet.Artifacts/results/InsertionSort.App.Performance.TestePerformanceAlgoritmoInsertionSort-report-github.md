``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.3693/22H2/2022Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.404
  [Host]     : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2


```
|                        Method |         Array |                 Mean |              Error |             StdDev |               Median | Rank | Allocated |
|------------------------------ |-------------- |---------------------:|-------------------:|-------------------:|---------------------:|-----:|----------:|
| **MedirPerformanceInsertionSort** | **Int32[100000]** |       **100,408.537 ns** |        **530.2659 ns** |        **442.7960 ns** |       **100,443.494 ns** |    **7** |         **-** |
|    MedirPerformanceBubbleSort | Int32[100000] | 3,692,133,146.154 ns | 26,653,790.4489 ns | 22,257,122.1811 ns | 3,686,504,900.000 ns |   10 |     600 B |
| **MedirPerformanceInsertionSort** |  **Int32[10000]** |         **9,964.832 ns** |        **155.6495 ns** |        **145.5946 ns** |         **9,942.171 ns** |    **6** |         **-** |
|    MedirPerformanceBubbleSort |  Int32[10000] |    36,639,961.429 ns |    326,942.3144 ns |    305,822.0438 ns |    36,603,700.000 ns |    9 |      43 B |
| **MedirPerformanceInsertionSort** |   **Int32[1000]** |           **986.409 ns** |          **9.4241 ns** |          **7.3577 ns** |           **988.459 ns** |    **4** |         **-** |
|    MedirPerformanceBubbleSort |   Int32[1000] |       372,929.548 ns |      3,337.6481 ns |      2,958.7381 ns |       372,402.246 ns |    8 |         - |
| **MedirPerformanceInsertionSort** |    **Int32[100]** |           **104.724 ns** |          **2.0950 ns** |          **2.1514 ns** |           **104.011 ns** |    **3** |         **-** |
|    MedirPerformanceBubbleSort |    Int32[100] |         3,896.600 ns |         30.7276 ns |         27.2393 ns |         3,901.847 ns |    5 |         - |
| **MedirPerformanceInsertionSort** |     **Int32[10]** |             **9.384 ns** |          **0.1197 ns** |          **0.1061 ns** |             **9.383 ns** |    **1** |         **-** |
|    MedirPerformanceBubbleSort |     Int32[10] |            40.923 ns |          1.0620 ns |          2.9251 ns |            39.507 ns |    2 |         - |
