# NLP-Based Turkish Song Lyric Synthesizing

This project aims to synthesize Turkish song lyrics using Natural Language Processing (NLP). The project is divided into four main components:

1. **Web Scraping for Song Lyrics**: A Python script that scrapes song lyrics from the website `https://www.sarkisozleri.bbs.tr`. The scraped lyrics are then saved in a JSON format, categorized by their detected language.

2. **NLP Model**: A set of Python scripts that train and control an NLP model for lyric synthesis.

3. **Desktop Application**: A Python-based desktop application that interacts with the NLP model to generate song lyrics based on user input.

4. **Prompt Automation**: A C# application that automates the process of generating prompts for the NLP model.

## Features

- **Song URL Collection**: The script collects URLs of songs from the target website and saves them in a CSV file.
  
- **Lyric Scraping**: The lyrics of the songs are scraped and saved in a JSON format. The lyrics are categorized based on their detected language (Turkish, English, German, or Unknown).

- **NLP Model Training and Control**: The NLP model can be trained using the collected lyrics and can be controlled to generate synthesized lyrics.

- **Desktop Application Interface**: Users can interact with the NLP model through a desktop application to generate song lyrics.

- **Prompt Automation**: Automates the process of generating prompts for the NLP model using a C# application.

## Related Projects

This project is a part of a larger effort that includes three other projects:

1. **Desktop Application**: A user-friendly interface for interacting with the NLP model. [View Code](https://github.com/kkrgzz/NLP-Based-Turkish-Song-Lyric-Synthesizing/tree/main/Desktop%20Application)

2. **NLP Model**: The core NLP model responsible for synthesizing Turkish song lyrics. [View Code](https://github.com/kkrgzz/NLP-Based-Turkish-Song-Lyric-Synthesizing/tree/main/NLP%20Model)

3. **Prompt Automation**: A tool for automating the generation of prompts for the NLP model. [View Code](https://github.com/kkrgzz/NLP-Based-Turkish-Song-Lyric-Synthesizing/tree/main/Prompt%20Automation)

## Getting Started

1. Clone the repository.
2. Install the required dependencies.
3. Run the web scraping script to collect song URLs and lyrics.
4. Train the NLP model using the collected lyrics.
5. Launch the desktop application to interact with the NLP model and generate song lyrics.

## Dependencies

- Python 3.x
- Requests
- BeautifulSoup
- Pandas
- Langdetect

## Authors

- **[Kemal Karagöz](https://github.com/kkrgzz)** - Initial work and development.

## Contribution

Feel free to contribute to this project by submitting pull requests or raising issues.
