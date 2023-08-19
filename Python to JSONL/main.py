import json
import os

file_directory = "./dataset/"
target_directory = "./output.jsonl"
contents_in_directory = os.listdir(file_directory)
character_count = 0

def pre_trained_data_jsonl():
    """Converts individual JSON files into a single JSONL file."""
    for i in range(len(contents_in_directory)):
        selected_file_with_path = file_directory + contents_in_directory[i]
        
        with open(selected_file_with_path) as _file:
            _json_data = json.load(_file)
        
        for _data in _json_data:
            character_count += len(_data["prompt"]) + len(_data["lyrics"])
            json_dict = {
                "prompt": _data["prompt"],
                "completion": _data["lyrics"]
            }
            
            with open(target_directory, "a") as save_to_file:
                json.dump(json_dict, save_to_file)
                save_to_file.write('\n')

        print(f"Files Remaining: {len(contents_in_directory) - i}")

def pre_train_data_normal():
    """Processes the data for training, removing specific words and maintaining a word count limit."""
    word_count = 0

    for i in range(len(contents_in_directory)):
        selected_file_with_path = file_directory + contents_in_directory[i]
        
        with open(selected_file_with_path) as _file:
            _json_data = json.load(_file)
        
        for _data in _json_data:
            word_count += len(_data["prompt"].split()) + len(_data["lyrics"].split())
           
            if word_count <= 20000:
                for word in ["anlatıyor", "vurguluyor", "söylüyor"]:
                    _data["prompt"] = _data["prompt"].replace(word, '')
                
                with open("./train-data.txt", "a", encoding="utf-8") as save_to_file:
                    save_to_file.write(_data["prompt"])
                    save_to_file.write("\n")
                    save_to_file.write(_data["lyrics"])
                    save_to_file.write("\n")

pre_train_data_normal()
