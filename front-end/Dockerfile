FROM public.ecr.aws/docker/library/node:20-alpine AS build
WORKDIR /app
RUN npm install -g @angular/cli
COPY package*.json ./
RUN npm install
COPY . .
RUN npm run build --prod


FROM public.ecr.aws/docker/library/node:20-alpine AS development
WORKDIR /app
RUN npm install -g @angular/cli
COPY package*.json ./
RUN npm install
COPY . .
