import json
import os

file_directory = "./dataset/"
target_directory = "./output.jsonl"

#Klasörün içerisine girip, klasördeki tüm dokümanları dizi içerisine kaydediyor.
contents_in_directory = os.listdir(file_directory)

character_count = 0


def pre_trained_data_jsonl():
    #0 dan başlayıp toplam dosya sayısına kadar bir döngü oluşturuyor
    for i in range(0, len(contents_in_directory)):
        # Döngü içerisinde i değişkeni aracılığıyla sırası ile dosyaları seçiyor
        selected_file = contents_in_directory[i]
        
        # klasör konumunu ve dosya adını birleştiriyor
        selected_file_with_path = file_directory + selected_file

        # okunacak json dosyası açılıyor
        _file = open(selected_file_with_path)

        # Açılan dosya json olarak parslanıp değişkene kaydediliyor
        _json_data = json.load(_file)
        
        # JSON verisinin içerisinde ilk objeye erişmek için for döngüsü başlatılıyor
        for _data in _json_data:

            # JSON dosyasının içerisinde prompt ve lyrics elemanlarını Pythonda 
            # Dictionary objesi haline getiriyor
            character_count += len(_data["prompt"])
            character_count += len(_data["lyrics"])
            json_dict = {
                "prompt": _data["prompt"],
                "completion": _data["lyrics"]
            }
            
            # a = append (iliştirmek)
            # output.jsonl dosyasını açıyor ve yeni yazılacak bilgileri dosyanın sonuna ekliyor.
            # burada açılan dosyayı kullanabilmek için 'as' tanımı yaptık ve artık bunu 
            # save_to_file olarak kullanacağız.
            with open(target_directory, "a") as save_to_file:
                
                # Dictionary dosyasını json formatına dönüştürüyor.
                json.dump(json_dict, save_to_file)
                # Eldeki json verisi dosyaya yazılıyor.
                save_to_file.write('\n')

        # konsola çok güzel şeyler yazabiliyosun.
        print("Remaining: ", str(len(contents_in_directory) - i))

def pre_train_data_normal():
    word_count = 0

    #0 dan başlayıp toplam dosya sayısına kadar bir döngü oluşturuyor
    for i in range(0, len(contents_in_directory)):
        # Döngü içerisinde i değişkeni aracılığıyla sırası ile dosyaları seçiyor
        selected_file = contents_in_directory[i]
        
        # klasör konumunu ve dosya adını birleştiriyor
        selected_file_with_path = file_directory + selected_file

        # okunacak json dosyası açılıyor
        _file = open(selected_file_with_path)

        # Açılan dosya json olarak parslanıp değişkene kaydediliyor
        _json_data = json.load(_file)
        
        # JSON verisinin içerisinde ilk objeye erişmek için for döngüsü başlatılıyor
        for _data in _json_data:
            
            # a = append (iliştirmek)
            # output.jsonl dosyasını açıyor ve yeni yazılacak bilgileri dosyanın sonuna ekliyor.
            # burada açılan dosyayı kullanabilmek için 'as' tanımı yaptık ve artık bunu 
            # save_to_file olarak kullanacağız.
            word_count += len(_data["prompt"].split(" "))
            word_count += len(_data["lyrics"].split(" "))
           
            if word_count <= 20000:
                _data["prompt"] = _data["prompt"].replace("anlatıyor", '')
                _data["prompt"] = _data["prompt"].replace("vurguluyor", '')
                _data["prompt"] = _data["prompt"].replace("söylüyor", '')
                print(word_count)
                with open("./train-data.txt", "a", encoding="utf-8") as save_to_file:
                    save_to_file.write(_data["prompt"])
                    save_to_file.write("\n")
                    save_to_file.write(_data["lyrics"])
                    save_to_file.write("\n")

        # konsola çok güzel şeyler yazabiliyosun.
        #print("Remaining: ", str(len(contents_in_directory) - i))


pre_train_data_normal()