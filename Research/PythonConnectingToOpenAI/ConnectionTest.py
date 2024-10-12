from flask import Flask, jsonify, request
from flask_cors import CORS

app = Flask(__name__)
CORS(app)


@app.route('/get-data', methods=['GET'])
def get_data():
    data = {"message": "To jest wiadomość z Pythona!"}
    return jsonify(data)


@app.route('/send-data', methods=['POST'])
def send_data():
    received_data = request.json
    print(f"Otrzymano dane z Nuxt: {received_data}")
    return jsonify({"status": "Dane otrzymane"})

if __name__ == '__main__':
    app.run(port=5000)