# Steps to do K8s
1. Pray
2. Cry
3. ???
4. Profit

## Dockerize your frontend project
1. Create .dockerignore
2. Create dockerfile and explaining what each command does
3. Docker build -t <YourUsernameInDockerHub>/<NameOfImage>:<Version>
4. Docker run -d -p 4200:80 -t <YourUsernameInDockerHub>/<NameOfImage>:<Version>
5. Publish to Dockerhub

## Dockerize your API
1. Do Steps 1-3
2. Docker run -d -p 5001:80 -t <YourUsernameInDockerHub>/<NameOfImage>:<Version>
3. Publish to Dockerhub

## Setting up K8s in the Azure
1. Go to Kubernetes service in Azure
2. Create K8s cluster
3. Check my video for the properties I changed
4. Install Chocolately to get Azure CLI, KubeCTL, Helm

## Connecting your CLI to the Azure K8s
1. Go to K8s overview and click Connect
2. Copy and paste the AZ CLI command

## Setting up Deployment and Service
1. Create service YAML file
2. Get a template from MS docs or get it from my GitHub
3. Change the image and name
4. kubectl apply -f <YAMLName>

## Setting up Ingress
1. helm repo add ingress-nginx https://kubernetes.github.io//ingress-nginx
2. helm install nginx-ingress ingress-nginx/ingress-nginx --set controller.replicaCount=2 --set controller.nodeSelector."beta\.kubernetes\.io/os"=linux --set defaultBackend.nodeSelector."beta\.kubernetes\.io/os"=linux
3. Create ingress YAML file
4. Get a template from ingress docs or get it from my GitHub
5. kubectl apply -f <YAMLName>

## Finally
1. Get external ip using "kubectl get service" command from your ingress controller
2. Check if ip routes you to the frontend and add "/api/api" to see if it route you to your backend
3. Fix CORS issue by setting CORS in backend and changing URL endpoint in your frontend

## Happiness