using SpeechSample;
//using WeihanLi.Extensions;
//using WeihanLi.Extensions;

public class GenerateVoiceOutput
{
    public static async Task MainTestAsync()
    {
        const string txtFilePath = @"C:\Users\xiyueyu\Desktop\questions.txt";
        var index = 0;
        foreach (var line in await File.ReadAllLinesAsync(txtFilePath))
        {
            if (string.IsNullOrEmpty(line) || string.IsNullOrWhiteSpace(line)) continue;
            index++;
            var outputFileName = $"{index}-output.wav";
            await Helper.TextToSpeechAsync(line, outputFileName, "zh-CN-XiaoshuangNeural");
        }
    }
}
