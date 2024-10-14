from openai import OpenAI
import os
from dotenv import load_dotenv

load_dotenv()

key = os.getenv("OPENAI_API_KEY")

client = OpenAI(api_key=key)

def get_openai_response():
    # Funkcja do pobrania odpowiedzi od OpenAI
    completion = client.chat.completions.create(
        model="gpt-3.5-turbo",
        messages=[
            {"role": "system", "content": "You are a helpful assistant."},
            {"role": "user", "content": "Siema odpisz mi czesc i nic wiecej"}
        ]
    )
    print(completion.choices[0].message)
    return completion.choices[0].message
  
get_openai_response()