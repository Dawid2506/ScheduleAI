from flask import Flask, jsonify, request
from flask_cors import CORS
from ChatbotConnect import get_openai_response

app = Flask(__name__)
CORS(app)


@app.route('/get-data', methods=['GET'])
def get_data():
    data = {"message": "To jest wiadomość z Pythona! nowa"}
    return jsonify(data)

@app.route('/get-ai-response', methods=['GET'])
def get_ai_response():
    try:
        ai_message = get_openai_response()
        return jsonify({"message": ai_message.content})  # .content, ponieważ zwraca obiekt
    except Exception as e:
        print(f"Error occurred: {e}")
        return jsonify({"error": str(e)}), 500


@app.route('/send-data', methods=['POST'])
def send_data():
    received_data = request.json
    print(f"Otrzymano dane z Nuxt: {received_data}")
    return jsonify({"status": "Dane otrzymane"})

if __name__ == '__main__':
    app.run(port=5000)